namespace Unreal_Store
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkCreateAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
             
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
             
            this.lblTitle.Text = "INICIAR SESSÃO";
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 24);
            this.lblTitle.Size = new System.Drawing.Size(640, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.txtUsername.Location = new System.Drawing.Point(80, 110);
            this.txtUsername.Size = new System.Drawing.Size(480, 24);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Text = "NOME DE UTILIZADOR";
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
             
            this.txtPassword.Location = new System.Drawing.Point(80, 160);
            this.txtPassword.Size = new System.Drawing.Size(480, 24);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Text = "PALAVRA-PASSE";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
             
            this.btnSignIn.Location = new System.Drawing.Point(80, 220);
            this.btnSignIn.Size = new System.Drawing.Size(480, 36);
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(150, 210, 170);
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Text = "INICIAR SESSÃO";
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
             
            this.linkCreateAccount.Location = new System.Drawing.Point(80, 268);
            this.linkCreateAccount.Size = new System.Drawing.Size(480, 20);
            this.linkCreateAccount.TabIndex = 3;
            this.linkCreateAccount.Text = "Não tem conta? Criar conta";
            this.linkCreateAccount.LinkColor = System.Drawing.Color.LightBlue;
            this.linkCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
             
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.linkCreateAccount);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
