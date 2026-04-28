using System;
using System.IO;

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
            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 1) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase)) return true;
            }
            return false;
        }

        public static void AddAccount(string username, string password)
        {
            EnsureStore();
            File.AppendAllText(FilePath, $"{username}|{password}{Environment.NewLine}");
        }

        public static bool CheckCredentials(string username, string password)
        {
            EnsureStore();
            foreach (var line in File.ReadAllLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length != 2) continue;
                if (string.Equals(parts[0], username, StringComparison.OrdinalIgnoreCase) && parts[1] == password)
                    return true;
            }
            return false;
        }
    }
}