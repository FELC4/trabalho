using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Unreal_Store;
using System.Linq;

namespace Unreal_Store
{
    internal static class AccountStore
    {
        private static string FolderPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Unreal_Store");

        private static string FilePath => Path.Combine(FolderPath, "accounts.txt");

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

        // format: username|password|balance|game1,game2,...
        public static void AddAccount(string username, string password)
        {
            EnsureStore();
            File.AppendAllText(FilePath, $"{username}|{password}|0|{Environment.NewLine}");
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
            // not found -> add
            File.AppendAllText(FilePath, $"{username}|{string.Empty}|{newBalance.ToString(CultureInfo.InvariantCulture)}|{Environment.NewLine}");
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
            // not found -> create with game
            File.AppendAllText(FilePath, $"{username}|{string.Empty}|0|{gameId}{Environment.NewLine}");
        }
    }
}