using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Unreal_Store
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Testar conexão com erro detalhado
            try
            {
                string connectionString = @"(localdb)\MSSQLLocalDB;Database=Unreal_StoreBD;Integrated Security=True;";
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Conexão bem-sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro de conexão detalhado:\n\n" +
                    $"Mensagem: {ex.Message}\n\n" +
                    $"Stack Trace:\n{ex.StackTrace}",
                    "Erro de Conexão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1());
        }
    }
}