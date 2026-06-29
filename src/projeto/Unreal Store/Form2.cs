using System;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form2 : Form
    {
        public string CreatedUsername { get; private set; }
        public string CreatedPassword { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var username = txtNewUsername.Text?.Trim() ?? string.Empty;
            var pass = txtNewPassword.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Nome de utilizador e palavra-passe são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Length < 3 || username.Contains(" "))
            {
                MessageBox.Show("Por favor introduza um nome de utilizador válido (mín. 3 caracteres, sem espaços).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AccountStore.AccountExists(username))
            {
                MessageBox.Show("Já existe uma conta com este nome de utilizador.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccountStore.AddAccount(username, pass);
            CreatedUsername = username;
            CreatedPassword = pass;
            MessageBox.Show("Conta criada com sucesso.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}