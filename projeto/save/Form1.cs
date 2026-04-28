Form1.Designer.cs
namespace Unreal_Store
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Login";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Text = "SIGN IN";
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(300, 40);
            this.lblTitle.Size = new System.Drawing.Size(200, 20);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.pnlEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmail.Location = new System.Drawing.Point(170, 120);
            this.pnlEmail.Size = new System.Drawing.Size(460, 46);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(182, 132);
            this.txtEmail.Size = new System.Drawing.Size(436, 18);
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Location = new System.Drawing.Point(170, 200);
            this.pnlPassword.Size = new System.Drawing.Size(460, 46);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(34, 34, 34);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(182, 212);
            this.txtPassword.Size = new System.Drawing.Size(436, 18);
            this.txtPassword.Text = "PASSWORD";
            this.txtPassword.UseSystemPasswordChar = false; // initial placeholder not masked
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(150, 210, 170);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.Location = new System.Drawing.Point(170, 300);
            this.btnSignIn.Size = new System.Drawing.Size(460, 44);
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // Add controls to form (order matters for z-order)
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.txtEmail);    // added after panels so textbox is on top
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSignIn);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}