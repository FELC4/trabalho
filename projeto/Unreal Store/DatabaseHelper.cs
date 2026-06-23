using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Unreal_Store
{
    public static class DatabaseHelper
    {
        // STRING DE CONEXÃO SIMPLES - Use esta!
        private static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Unreal_StoreBD;Integrated Security=True;";

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        #region Métodos de Utilizador

        public static bool AccountExists(string username)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Utilizadores WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar conta: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CheckCredentials(string username, string password)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Utilizadores WHERE Username = @Username AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credenciais: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void AddAccount(string username, string password)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("INSERT INTO Utilizadores (Username, Password) VALUES (@Username, @Password)", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static decimal GetBalance(string username)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT Balance FROM Utilizadores WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
            catch
            {
                return 0m;
            }
        }

        public static void SetBalance(string username, decimal newBalance)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("UPDATE Utilizadores SET Balance = @Balance WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Balance", newBalance);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar saldo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddFunds(string username, decimal amount)
        {
            if (amount <= 0) return;
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("UPDATE Utilizadores SET Balance = Balance + @Amount WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar fundos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool TrySpend(string username, decimal amount)
        {
            if (amount <= 0) return false;
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("SELECT Balance FROM Utilizadores WHERE Username = @Username", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Username", username);
                                var balance = Convert.ToDecimal(cmd.ExecuteScalar());
                                if (balance < amount) return false;
                            }

                            using (var cmd = new SqlCommand("UPDATE Utilizadores SET Balance = Balance - @Amount WHERE Username = @Username", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Username", username);
                                cmd.Parameters.AddWithValue("@Amount", amount);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static void DeleteUser(string username)
        {
            try
            {
                int userId = GetUserId(username);
                if (userId == -1) return;

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("DELETE FROM JogosComprados WHERE UserID = @UserID", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd = new SqlCommand("DELETE FROM Utilizadores WHERE UserID = @UserID", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static int GetUserId(string username)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT UserID FROM Utilizadores WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static void UpdateUser(string oldUsername, string newUsername, string newPassword)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("UPDATE Utilizadores SET Username = @NewUsername, Password = @Password WHERE Username = @OldUsername", conn))
                {
                    cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@OldUsername", oldUsername);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public static string GetUserPassword(string username)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT Password FROM Utilizadores WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? result.ToString() : string.Empty;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public static UserInfo GetUserInfo(string username)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT Username, Password, Balance FROM Utilizadores WHERE Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserInfo
                            {
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return null;
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de conexão detalhado:\n\n{ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Métodos de Jogos

        public static int GetGameIdByCode(string gameCode)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT GameID FROM Jogos WHERE GameCode = @GameCode", conn))
                {
                    cmd.Parameters.AddWithValue("@GameCode", gameCode);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        public static decimal GetGamePrice(string gameId)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT Price FROM Jogos WHERE GameCode = @GameCode", conn))
                {
                    cmd.Parameters.AddWithValue("@GameCode", gameId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
            catch
            {
                return 0m;
            }
        }

        public static string GetGameTitle(string gameId)
        {
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT Title FROM Jogos WHERE GameCode = @GameCode", conn))
                {
                    cmd.Parameters.AddWithValue("@GameCode", gameId);
                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? result.ToString() : "Jogo Desconhecido";
                }
            }
            catch
            {
                return "Jogo Desconhecido";
            }
        }

        public static List<GameInfo> GetAllGames()
        {
            var games = new List<GameInfo>();
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT GameCode, Title, Price FROM Jogos WHERE IsActive = 1 ORDER BY Price", conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            games.Add(new GameInfo
                            {
                                GameCode = reader["GameCode"].ToString(),
                                Title = reader["Title"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"])
                            });
                        }
                    }
                }
            }
            catch
            {
                // Retorna lista vazia em caso de erro
            }
            return games;
        }

        #endregion

        #region Métodos de Jogos Comprados

        public static List<string> GetOwnedGames(string username)
        {
            var games = new List<string>();
            try
            {
                using (var conn = GetConnection())
                using (var cmd = new SqlCommand(@"
                    SELECT j.GameCode
                    FROM JogosComprados jc
                    INNER JOIN Utilizadores u ON jc.UserID = u.UserID
                    INNER JOIN Jogos j ON jc.GameID = j.GameID
                    WHERE u.Username = @Username", conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            games.Add(reader["GameCode"].ToString());
                        }
                    }
                }
            }
            catch
            {
                // Retorna lista vazia em caso de erro
            }
            return games;
        }

        public static bool HasGame(string username, string gameId)
        {
            try
            {
                int gameIdInt = GetGameIdByCode(gameId);
                if (gameIdInt == -1) return false;

                int userId = GetUserId(username);
                if (userId == -1) return false;

                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM JogosComprados WHERE UserID = @UserID AND GameID = @GameID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@GameID", gameIdInt);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static void AddOwnedGame(string username, string gameId)
        {
            try
            {
                int userId = GetUserId(username);
                if (userId == -1) return;

                int gameIdInt = GetGameIdByCode(gameId);
                if (gameIdInt == -1) return;

                if (HasGame(username, gameId)) return;

                decimal price = GetGamePrice(gameId);

                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("INSERT INTO JogosComprados (UserID, GameID, AmountPaid) VALUES (@UserID, @GameID, @AmountPaid)", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@GameID", gameIdInt);
                    cmd.Parameters.AddWithValue("@AmountPaid", price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar jogo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveOwnedGame(string username, string gameId)
        {
            try
            {
                int userId = GetUserId(username);
                if (userId == -1) return;

                int gameIdInt = GetGameIdByCode(gameId);
                if (gameIdInt == -1) return;

                using (var conn = GetConnection())
                using (var cmd = new SqlCommand("DELETE FROM JogosComprados WHERE UserID = @UserID AND GameID = @GameID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@GameID", gameIdInt);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover jogo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool TryRefund(string username, string gameId)
        {
            try
            {
                decimal price = GetGamePrice(gameId);
                if (price <= 0) return false;

                if (!HasGame(username, gameId)) return false;

                int userId = GetUserId(username);
                if (userId == -1) return false;

                int gameIdInt = GetGameIdByCode(gameId);
                if (gameIdInt == -1) return false;

                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = new SqlCommand("DELETE FROM JogosComprados WHERE UserID = @UserID AND GameID = @GameID", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.Parameters.AddWithValue("@GameID", gameIdInt);
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd = new SqlCommand("UPDATE Utilizadores SET Balance = Balance + @Price WHERE UserID = @UserID", conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.Parameters.AddWithValue("@Price", price);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }

    #region Classes Auxiliares

    public class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
    }

    public class GameInfo
    {
        public string GameCode { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    #endregion
}