using System;
using System.Collections.Generic;

namespace Unreal_Store
{
    internal static class AccountStore
    {
        public const string GAME_ACAO = "ACAO";
        public const string GAME_EXPLORACAO = "EXPLORACAO";
        public const string GAME_POINTCLICK = "POINTCLICK";
        public const string GAME_MULTI = "MULTI";

        public static bool AccountExists(string username) => DatabaseHelper.AccountExists(username);
        public static bool CheckCredentials(string username, string password) => DatabaseHelper.CheckCredentials(username, password);
        public static void AddAccount(string username, string password) => DatabaseHelper.AddAccount(username, password);
        public static decimal GetBalance(string username) => DatabaseHelper.GetBalance(username);
        public static void SetBalance(string username, decimal newBalance) => DatabaseHelper.SetBalance(username, newBalance);
        public static void AddFunds(string username, decimal amount) => DatabaseHelper.AddFunds(username, amount);
        public static bool TrySpend(string username, decimal amount) => DatabaseHelper.TrySpend(username, amount);

        public static decimal GetGamePrice(string gameId) => DatabaseHelper.GetGamePrice(gameId);
        public static string GetGameTitle(string gameId) => DatabaseHelper.GetGameTitle(gameId);

        public static List<string> GetOwnedGames(string username) => DatabaseHelper.GetOwnedGames(username);
        public static bool HasGame(string username, string gameId) => DatabaseHelper.HasGame(username, gameId);
        public static void AddOwnedGame(string username, string gameId) => DatabaseHelper.AddOwnedGame(username, gameId);
        public static void RemoveOwnedGame(string username, string gameId) => DatabaseHelper.RemoveOwnedGame(username, gameId);
        public static bool TryRefund(string username, string gameId) => DatabaseHelper.TryRefund(username, gameId);

        public static void DeleteUser(string username) => DatabaseHelper.DeleteUser(username);
        public static void UpdateUser(string oldUsername, string newUsername, string newPassword) => DatabaseHelper.UpdateUser(oldUsername, newUsername, newPassword);
        public static string GetUserPassword(string username) => DatabaseHelper.GetUserPassword(username);
        public static UserInfo GetUserInfo(string username) => DatabaseHelper.GetUserInfo(username);

        public static bool TestConnection() => DatabaseHelper.TestConnection();
    }
}