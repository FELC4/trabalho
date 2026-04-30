namespace Unreal_Store
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(12, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(396, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Criar conta";

            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(396, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nome de utilizador";

            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(396, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Palavra-passe";

            this.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewUsername.ForeColor = System.Drawing.Color.White;
            this.txtNewUsername.Location = new System.Drawing.Point(12, 56);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(396, 25);
            this.txtNewUsername.TabIndex = 2;

            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.Location = new System.Drawing.Point(12, 106);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(396, 25);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;

            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(220, 136);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 30);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Criar";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(312, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}