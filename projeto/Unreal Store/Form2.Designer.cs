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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.ClientSize = new System.Drawing.Size(420, 170);
            this.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Criar conta";
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            
            this.lblHeader.Text = "Criar conta";
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(12, 10);
            this.lblHeader.Size = new System.Drawing.Size(396, 24);
           
            this.lblUsername.Text = "Nome de utilizador";
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 36);
            this.lblUsername.Size = new System.Drawing.Size(396, 18);
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
           
            this.txtNewUsername.Location = new System.Drawing.Point(12, 56);
            this.txtNewUsername.Size = new System.Drawing.Size(396, 24);
            this.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtNewUsername.ForeColor = System.Drawing.Color.Black;
            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
           
            this.lblPassword.Text = "Palavra-passe";
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 86);
            this.lblPassword.Size = new System.Drawing.Size(396, 18);
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            
            this.txtNewPassword.Location = new System.Drawing.Point(12, 106);
            this.txtNewPassword.Size = new System.Drawing.Size(396, 24);
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(36, 36, 36);
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            
            this.btnCreate.Location = new System.Drawing.Point(220, 136);
            this.btnCreate.Size = new System.Drawing.Size(85, 30);
            this.btnCreate.Text = "Criar";
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            
            this.btnCancel.Location = new System.Drawing.Point(312, 136);
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}