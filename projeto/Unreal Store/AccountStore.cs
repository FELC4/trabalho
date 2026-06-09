using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Unreal_Store
{
    internal static class AccountStore
    {
        private static string FolderPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Unreal_Store");

        private static string FilePath => Path.Combine(FolderPath, "accounts.txt");

        // IDs dos jogos
        public const string GAME_ACAO = "ACAO";
        public const string GAME_EXPLORACAO = "EXPLORACAO";
        public const string GAME_POINTCLICK = "POINTCLICK";
        public const string GAME_MULTI = "MULTI";

        // Preços dos jogos para reembolso
        public static decimal GetGamePrice(string gameId)
        {
            switch (gameId)
            {
                case GAME_ACAO: return 19.99m;
                case GAME_EXPLORACAO: return 9.99m;
                case GAME_POINTCLICK: return 3.99m;
                case GAME_MULTI: return 0m;
                default: return 0m;
            }
        }

        public static string GetGameTitle(string gameId)
        {
            switch (gameId)
            {
                case GAME_ACAO: return "Jogo de Ação";
                case GAME_EXPLORACAO: return "Jogo de Exploração";
                case GAME_POINTCLICK: return "Point-and-Click 2D";
                case GAME_MULTI: return "Multi-jogador";
                default: return "Jogo Desconhecido";
            }
        }

        public static void EnsureStore()
        {
            if (!Directory.Exists(FolderPath)) Directory.CreateDirectory(FolderPath);
            if (!File.Exists(FilePath)) File.WriteAllText(FilePath, string.Empty);
        }

        public static bool AccountExists(string username)
        {
            EnsureStore();
            return File.ReadLines(FilePath).Any(l =>
            {
                var parts = l.Split('|');
                return parts.Length > 0 && string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase);
            });
        }

        public static void AddAccount(string username, string password)
        {
            EnsureStore();
            File.AppendAllText(FilePath, $"{username}|{password}|0||{Environment.NewLine}");
        }

        public static bool CheckCredentials(string username, string password)
        {
            EnsureStore();
            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 2) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase) && parts[1] == password)
                    return true;
            }
            return false;
        }

        public static decimal GetBalance(string username)
        {
            EnsureStore();
            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 1) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase))
                {
                    if (parts.Length >= 3 && decimal.TryParse(parts[2], NumberStyles.Number, CultureInfo.InvariantCulture, out var b))
                        return b;
                    return 0m;
                }
            }
            return 0m;
        }

        public static void SetBalance(string username, decimal newBalance)
        {
            EnsureStore();
            var lines = File.ReadAllLines(FilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split('|').ToList();
                if (parts.Count == 0) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase))
                {
                    var pwd = parts.Count >= 2 ? parts[1] : string.Empty;
                    var games = parts.Count >= 4 ? parts[3] : string.Empty;
                    lines[i] = $"{username}|{pwd}|{newBalance.ToString(CultureInfo.InvariantCulture)}|{games}";
                    File.WriteAllLines(FilePath, lines);
                    return;
                }
            }
            File.AppendAllText(FilePath, $"{username}|{string.Empty}|{newBalance.ToString(CultureInfo.InvariantCulture)}||{Environment.NewLine}");
        }

        public static void AddFunds(string username, decimal amount)
        {
            EnsureStore();
            var current = GetBalance(username);
            SetBalance(username, current + amount);
        }

        public static bool TrySpend(string username, decimal amount)
        {
            if (amount <= 0) return false;
            EnsureStore();
            var current = GetBalance(username);
            if (current >= amount)
            {
                SetBalance(username, current - amount);
                return true;
            }
            return false;
        }

        public static bool TryRefund(string username, string gameId)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(gameId)) return false;

            // Verificar se o jogo existe na biblioteca
            if (!HasGame(username, gameId)) return false;

            // Jogos gratuitos não podem ser reembolsados
            decimal gamePrice = GetGamePrice(gameId);
            if (gamePrice <= 0) return false;

            // Remover o jogo da biblioteca
            RemoveOwnedGame(username, gameId);

            // Devolver o dinheiro
            AddFunds(username, gamePrice);

            return true;
        }

        public static void RemoveOwnedGame(string username, string gameId)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(gameId)) return;
            EnsureStore();

            var lines = File.ReadAllLines(FilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split('|').ToList();
                if (parts.Count == 0) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase))
                {
                    var pwd = parts.Count >= 2 ? parts[1] : string.Empty;
                    var balance = parts.Count >= 3 ? parts[2] : "0";
                    var games = parts.Count >= 4 ? parts[3] : string.Empty;

                    var list = new List<string>();
                    if (!string.IsNullOrWhiteSpace(games))
                        list.AddRange(games.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()));

                    if (list.Contains(gameId, StringComparer.OrdinalIgnoreCase))
                        list.RemoveAll(g => string.Equals(g, gameId, StringComparison.OrdinalIgnoreCase));

                    var newGames = string.Join(",", list);
                    lines[i] = $"{username}|{pwd}|{balance}|{newGames}";
                    File.WriteAllLines(FilePath, lines);
                    return;
                }
            }
        }

        public static IReadOnlyList<string> GetOwnedGames(string username)
        {
            EnsureStore();
            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 1) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase))
                {
                    if (parts.Length >= 4 && !string.IsNullOrWhiteSpace(parts[3]))
                    {
                        return parts[3].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();
                    }
                    return new List<string>();
                }
            }
            return new List<string>();
        }

        public static bool HasGame(string username, string gameId)
        {
            var games = GetOwnedGames(username);
            return games.Contains(gameId, StringComparer.OrdinalIgnoreCase);
        }

        public static void AddOwnedGame(string username, string gameId)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(gameId)) return;
            EnsureStore();
            var lines = File.ReadAllLines(FilePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split('|').ToList();
                if (parts.Count == 0) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase))
                {
                    var pwd = parts.Count >= 2 ? parts[1] : string.Empty;
                    var balance = parts.Count >= 3 ? parts[2] : "0";
                    var games = parts.Count >= 4 ? parts[3] : string.Empty;
                    var list = new List<string>();
                    if (!string.IsNullOrWhiteSpace(games))
                        list.AddRange(games.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()));
                    if (!list.Contains(gameId, StringComparer.OrdinalIgnoreCase))
                        list.Add(gameId);
                    var newGames = string.Join(",", list);
                    lines[i] = $"{username}|{pwd}|{balance}|{newGames}";
                    File.WriteAllLines(FilePath, lines);
                    return;
                }
            }
            File.AppendAllText(FilePath, $"{username}|{string.Empty}|0|{gameId}{Environment.NewLine}");
        }
    }
}