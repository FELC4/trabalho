using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Método ligado pelo Designer ao botão "Definições" (button4).
        private void button4_Click(object sender, EventArgs e)
        {
            using (var f4 = new Form4())
            {
                // Esconder Form3 enquanto as definições estão abertas
                this.Hide();

                var result = f4.ShowDialog(this);

                // Se o utilizador escolheu Logout, reexibir (ou criar) Form1 e fechar Form3
                if (result == DialogResult.OK && f4.IsLogout)
                {
                    var f1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                    if (f1 != null)
                    {
                        // Garantir que Form1 fica visível e em primeiro plano
                        if (!f1.Visible) f1.Show();
                        f1.WindowState = FormWindowState.Normal;
                        try
                        {
                            f1.BringToFront();
                            f1.Activate();
                        }
                        catch { /* não fatal se falhar */ }
                    }
                    else
                    {
                        // Caso improvável: criar nova instância de Form1
                        var newF1 = new Form1();
                        newF1.Show();
                    }

                    // Fechar Form3 para completar o logout
                    this.Close();
                    return;
                }

                // Caso o utilizador simplesmente fechou Form4 sem fazer logout,
                // reexibir Form3 (se ainda não estiver disposed)
                if (!this.IsDisposed)
                    this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // placeholder existente (Atualizar) — manter ou implementar lógica
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
