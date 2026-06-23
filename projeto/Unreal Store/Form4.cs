using System;
using System.Linq;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form4 : Form
    {
        public bool IsLogout { get; private set; }
        private string currentUsername;
        private string currentPassword;

        public Form4()
        {
            InitializeComponent();

            this.btnLogout.Click -= btnLogout_Click;
            this.btnLogout.Click += btnLogout_Click;

            this.btnBack.Click -= btnBack_Click;
            this.btnBack.Click += btnBack_Click;

            this.btnEditProfile.Click -= btnEditProfile_Click;
            this.btnEditProfile.Click += btnEditProfile_Click;

            this.btnSaveChanges.Click -= btnSaveChanges_Click;
            this.btnSaveChanges.Click += btnSaveChanges_Click;

            this.btnCancelEdit.Click -= btnCancelEdit_Click;
            this.btnCancelEdit.Click += btnCancelEdit_Click;

            this.btnDeleteAccount.Click -= btnDeleteAccount_Click;
            this.btnDeleteAccount.Click += btnDeleteAccount_Click;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            var form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();

            if (form3 != null && !string.IsNullOrWhiteSpace(form3.Username))
            {
                currentUsername = form3.Username;
                var userInfo = AccountStore.GetUserInfo(currentUsername);
                if (userInfo != null)
                {
                    lblUsernameValue.Text = currentUsername;
                    lblBalanceValue.Text = userInfo.Balance.ToString("C2", new System.Globalization.CultureInfo("pt-PT"));
                    txtNewUsername.Text = currentUsername;
                    currentPassword = userInfo.Password;
                    btnDeleteAccount.Enabled = true;
                    btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
                }
            }
            else
            {
                lblUsernameValue.Text = "Convidado";
                lblBalanceValue.Text = "0,00€";
                btnEditProfile.Enabled = false;
                btnEditProfile.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
                btnDeleteAccount.Enabled = false;
                btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            panelAccountActions.Visible = false;
            panelEditProfile.Visible = true;
            txtNewUsername.Text = currentUsername;
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            mainContentLabel.Text = "Definições - Editar Perfil";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUsername.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Por favor, insira um nome de utilizador.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newUsername.Length < 3 || newUsername.Contains(" "))
            {
                MessageBox.Show("O nome de utilizador deve ter pelo menos 3 caracteres e não pode conter espaços.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(newUsername, currentUsername, StringComparison.OrdinalIgnoreCase))
            {
                if (AccountStore.AccountExists(newUsername))
                {
                    MessageBox.Show("Já existe uma conta com este nome de utilizador.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (newPassword.Length < 3)
                {
                    MessageBox.Show("A palavra-passe deve ter pelo menos 3 caracteres.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("As palavras-passe não coincidem.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                newPassword = currentPassword;
            }

            DialogResult confirm = MessageBox.Show(
                $"Tem a certeza que deseja alterar o seu perfil?\n\nNovo Utilizador: {newUsername}",
                "Confirmar Alterações",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                AccountStore.UpdateUser(currentUsername, newUsername, newPassword);

                var form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
                if (form3 != null)
                {
                    form3.Username = newUsername;
                }

                currentUsername = newUsername;
                currentPassword = newPassword;

                UpdateUserInfo();
                btnCancelEdit_Click(sender, e);

                MessageBox.Show($"Perfil atualizado com sucesso!\n\nNovo Utilizador: {newUsername}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o perfil: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = false;
            panelAccountActions.Visible = true;
            mainContentLabel.Text = "Definições";
            txtNewUsername.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                $"⚠️ TEM A CERTEZA QUE DESEJA EXCLUIR A CONTA? ⚠️\n\n" +
                $"Conta: {currentUsername}\n\n" +
                "Esta ação é IRREVERSÍVEL e irá:\n" +
                "• Remover permanentemente a sua conta\n" +
                "• Perder todos os jogos na sua biblioteca\n" +
                "• Perder todo o saldo disponível\n\n" +
                "Deseja continuar?",
                "Confirmar Exclusão de Conta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (Form passwordForm = new Form())
            {
                passwordForm.Text = "Confirmar Exclusão";
                passwordForm.Size = new System.Drawing.Size(420, 200);
                passwordForm.StartPosition = FormStartPosition.CenterParent;
                passwordForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                passwordForm.MaximizeBox = false;
                passwordForm.MinimizeBox = false;
                passwordForm.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
                passwordForm.ForeColor = System.Drawing.Color.White;
                passwordForm.Font = new System.Drawing.Font("Segoe UI", 9F);

                Panel mainPanel = new Panel()
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(15),
                    BackColor = System.Drawing.Color.FromArgb(48, 48, 48)
                };

                Label lblTitle = new Label()
                {
                    Text = $"🔒 Verificação de Segurança",
                    ForeColor = System.Drawing.Color.LightBlue,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold),
                    Location = new System.Drawing.Point(0, 0),
                    Size = new System.Drawing.Size(390, 25),
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                };

                Label lblMessage = new Label()
                {
                    Text = $"Para confirmar a exclusão da conta '{currentUsername}',\ninsira a sua palavra-passe:",
                    ForeColor = System.Drawing.Color.WhiteSmoke,
                    Location = new System.Drawing.Point(0, 35),
                    Size = new System.Drawing.Size(390, 40),
                    Font = new System.Drawing.Font("Segoe UI", 9.5F)
                };

                Panel passwordPanel = new Panel()
                {
                    Location = new System.Drawing.Point(0, 85),
                    Size = new System.Drawing.Size(390, 30)
                };

                Label lblPassword = new Label()
                {
                    Text = "Palavra-passe:",
                    ForeColor = System.Drawing.Color.LightGray,
                    Location = new System.Drawing.Point(0, 5),
                    Size = new System.Drawing.Size(100, 20),
                    Font = new System.Drawing.Font("Segoe UI", 9F)
                };

                TextBox txtPassword = new TextBox()
                {
                    Location = new System.Drawing.Point(105, 2),
                    Size = new System.Drawing.Size(285, 25),
                    UseSystemPasswordChar = true,
                    BackColor = System.Drawing.Color.FromArgb(36, 36, 36),
                    ForeColor = System.Drawing.Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new System.Drawing.Font("Segoe UI", 10F)
                };

                passwordPanel.Controls.Add(lblPassword);
                passwordPanel.Controls.Add(txtPassword);

                Panel buttonPanel = new Panel()
                {
                    Location = new System.Drawing.Point(0, 125),
                    Size = new System.Drawing.Size(390, 40)
                };

                Button btnCancel = new Button()
                {
                    Text = "Cancelar",
                    Location = new System.Drawing.Point(190, 5),
                    Size = new System.Drawing.Size(100, 30),
                    BackColor = System.Drawing.Color.FromArgb(80, 80, 80),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold),
                    DialogResult = DialogResult.Cancel,
                    FlatAppearance = { BorderSize = 0 }
                };

                Button btnConfirm = new Button()
                {
                    Text = "🗑️ Excluir",
                    Location = new System.Drawing.Point(300, 5),
                    Size = new System.Drawing.Size(90, 30),
                    BackColor = System.Drawing.Color.FromArgb(200, 50, 50),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold),
                    DialogResult = DialogResult.OK,
                    FlatAppearance = { BorderSize = 0 }
                };

                buttonPanel.Controls.Add(btnCancel);
                buttonPanel.Controls.Add(btnConfirm);

                mainPanel.Controls.Add(lblTitle);
                mainPanel.Controls.Add(lblMessage);
                mainPanel.Controls.Add(passwordPanel);
                mainPanel.Controls.Add(buttonPanel);

                passwordForm.Controls.Add(mainPanel);
                passwordForm.AcceptButton = btnConfirm;
                passwordForm.CancelButton = btnCancel;

                passwordForm.Shown += (s, ev) => txtPassword.Focus();

                DialogResult result = passwordForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    string enteredPassword = txtPassword.Text;

                    if (enteredPassword != currentPassword)
                    {
                        MessageBox.Show("Palavra-passe incorreta.\nA exclusão da conta foi cancelada.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult finalConfirm = MessageBox.Show(
                        $"⚠️ EXCLUSÃO PERMANENTE ⚠️\n\n" +
                        $"A conta '{currentUsername}' será excluída permanentemente.\n\n" +
                        "Tem a certeza absoluta?",
                        "Confirmação Final",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);

                    if (finalConfirm != DialogResult.Yes) return;

                    try
                    {
                        AccountStore.DeleteUser(currentUsername);

                        var form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
                        if (form3 != null)
                        {
                            form3.Close();
                        }

                        this.Close();

                        MessageBox.Show($"A conta '{currentUsername}' foi excluída com sucesso.\n\nTodos os dados foram removidos permanentemente.", "Conta Excluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao excluir a conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem a certeza que deseja terminar a sessão?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                IsLogout = true;
                var form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
                if (form3 != null) form3.Close();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelEditProfile.Visible)
            {
                btnCancelEdit_Click(sender, e);
                return;
            }

            var form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();

            if (form3 != null)
            {
                try
                {
                    if (!form3.Visible) form3.Show();
                    form3.WindowState = FormWindowState.Normal;
                    form3.BringToFront();
                    form3.Activate();
                }
                catch { }
            }
            else
            {
                Form3 newForm3 = new Form3();
                newForm3.Show();
            }

            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (IsLogout) Application.Exit();
        }
    }
}