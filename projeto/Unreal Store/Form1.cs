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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnSignIn;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "NOME DE UTILIZADOR")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "NOME DE UTILIZADOR";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PALAVRA-PASSE")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "PALAVRA-PASSE";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text == "NOME DE UTILIZADOR" ? string.Empty : txtUsername.Text.Trim();
            var pass = txtPassword.Text == "PALAVRA-PASSE" ? string.Empty : txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, insira nome de utilizador e palavra-passe.", "Credenciais em falta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!AccountStore.CheckCredentials(username, pass))
            {
                MessageBox.Show("Conta não encontrada ou palavra-passe inválida. Se não tiver conta, crie uma.", "Autenticação falhada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form3 = new Form3();
            form3.FormClosed += (s, ea) => this.Close();
            form3.Show();
            this.Hide();
        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var createForm = new Form2())
            {
                if (createForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(createForm.CreatedUsername))
                    {
                        txtUsername.Text = createForm.CreatedUsername;
                        txtUsername.ForeColor = Color.White;
                        txtPassword.Text = "PALAVRA-PASSE";
                        txtPassword.ForeColor = Color.Gray;
                        txtPassword.UseSystemPasswordChar = false;
                    }
                }
            }
        }
    }
}
