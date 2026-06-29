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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtUsername, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btnSignIn, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.linkCreateAccount, 1, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(640, 360);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(160, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "INICIAR SESSÃO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(160, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "NOME DE UTILIZADOR";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(160, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "PALAVRA-PASSE";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(170)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(160, 188);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(320, 36);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "INICIAR SESSÃO";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkCreateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkCreateAccount.LinkColor = System.Drawing.Color.LightBlue;
            this.linkCreateAccount.Location = new System.Drawing.Point(160, 242);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(320, 20);
            this.linkCreateAccount.TabIndex = 3;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "Não tem conta? Criar conta";
            this.linkCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(480, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}