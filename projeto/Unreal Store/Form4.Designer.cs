namespace Unreal_Store
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelNavSettings;
        private System.Windows.Forms.Label lblSettingsIcon;
        private System.Windows.Forms.Label lblSettingsText;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label mainContentLabel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblUserInfoTitle;
        private System.Windows.Forms.Panel panelAccountActions;
        private System.Windows.Forms.Label lblAccountActionsTitle;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.Label lblEditProfileTitle;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel topBarPanel;

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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelNavSettings = new System.Windows.Forms.Panel();
            this.lblSettingsIcon = new System.Windows.Forms.Label();
            this.lblSettingsText = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.mainContentLabel = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblUserInfoTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.panelAccountActions = new System.Windows.Forms.Panel();
            this.lblAccountActionsTitle = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.lblEditProfileTitle = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelSidebar.SuspendLayout();
            this.panelNavSettings.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.panelAccountActions.SuspendLayout();
            this.panelEditProfile.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();

            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.panelSidebar, 0, 0);
            this.mainLayout.Controls.Add(this.topBarPanel, 1, 0);
            this.mainLayout.Controls.Add(this.mainContentPanel, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1000, 600);
            this.mainLayout.TabIndex = 0;

            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelSidebar.Controls.Add(this.panelNavSettings);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.mainLayout.SetRowSpan(this.panelSidebar, 2);
            this.panelSidebar.Size = new System.Drawing.Size(200, 600);
            this.panelSidebar.TabIndex = 0;

            // 
            // panelNavSettings
            // 
            this.panelNavSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelNavSettings.Controls.Add(this.lblSettingsIcon);
            this.panelNavSettings.Controls.Add(this.lblSettingsText);
            this.panelNavSettings.Location = new System.Drawing.Point(8, 30);
            this.panelNavSettings.Name = "panelNavSettings";
            this.panelNavSettings.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.panelNavSettings.Size = new System.Drawing.Size(184, 56);
            this.panelNavSettings.TabIndex = 0;

            // 
            // lblSettingsIcon
            // 
            this.lblSettingsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblSettingsIcon.ForeColor = System.Drawing.Color.White;
            this.lblSettingsIcon.Location = new System.Drawing.Point(12, 16);
            this.lblSettingsIcon.Name = "lblSettingsIcon";
            this.lblSettingsIcon.Size = new System.Drawing.Size(24, 24);
            this.lblSettingsIcon.TabIndex = 0;
            this.lblSettingsIcon.Text = "⚙️";
            this.lblSettingsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblSettingsText
            // 
            this.lblSettingsText.AutoSize = true;
            this.lblSettingsText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSettingsText.ForeColor = System.Drawing.Color.White;
            this.lblSettingsText.Location = new System.Drawing.Point(48, 18);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(75, 19);
            this.lblSettingsText.TabIndex = 1;
            this.lblSettingsText.Text = "Definições";

            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBarPanel.Location = new System.Drawing.Point(200, 0);
            this.topBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(800, 48);
            this.topBarPanel.TabIndex = 1;

            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainContentPanel.Controls.Add(this.mainContentLabel);
            this.mainContentPanel.Controls.Add(this.panelUserInfo);
            this.mainContentPanel.Controls.Add(this.panelAccountActions);
            this.mainContentPanel.Controls.Add(this.panelEditProfile);
            this.mainContentPanel.Controls.Add(this.btnBack);
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(203, 51);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(794, 546);
            this.mainContentPanel.TabIndex = 2;

            // 
            // mainContentLabel
            // 
            this.mainContentLabel.AutoSize = true;
            this.mainContentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.mainContentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentLabel.Location = new System.Drawing.Point(20, 10);
            this.mainContentLabel.Name = "mainContentLabel";
            this.mainContentLabel.Size = new System.Drawing.Size(109, 30);
            this.mainContentLabel.TabIndex = 0;
            this.mainContentLabel.Text = "Definições";

            // 
            // panelUserInfo
            // 
            this.panelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelUserInfo.Controls.Add(this.lblUserInfoTitle);
            this.panelUserInfo.Controls.Add(this.lblUsername);
            this.panelUserInfo.Controls.Add(this.lblUsernameValue);
            this.panelUserInfo.Controls.Add(this.lblBalance);
            this.panelUserInfo.Controls.Add(this.lblBalanceValue);
            this.panelUserInfo.Location = new System.Drawing.Point(30, 60);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(740, 120);
            this.panelUserInfo.TabIndex = 1;

            // 
            // lblUserInfoTitle
            // 
            this.lblUserInfoTitle.AutoSize = true;
            this.lblUserInfoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserInfoTitle.ForeColor = System.Drawing.Color.LightGreen;
            this.lblUserInfoTitle.Location = new System.Drawing.Point(15, 10);
            this.lblUserInfoTitle.Name = "lblUserInfoTitle";
            this.lblUserInfoTitle.Size = new System.Drawing.Size(125, 20);
            this.lblUserInfoTitle.TabIndex = 0;
            this.lblUserInfoTitle.Text = "INFORMAÇÃO DA CONTA";

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsername.Location = new System.Drawing.Point(15, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Utilizador:";

            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsernameValue.ForeColor = System.Drawing.Color.White;
            this.lblUsernameValue.Location = new System.Drawing.Point(120, 45);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(85, 19);
            this.lblUsernameValue.TabIndex = 2;
            this.lblUsernameValue.Text = "Convidado";

            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBalance.ForeColor = System.Drawing.Color.LightGray;
            this.lblBalance.Location = new System.Drawing.Point(15, 75);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 19);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Saldo:";

            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.AutoSize = true;
            this.lblBalanceValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBalanceValue.ForeColor = System.Drawing.Color.Gold;
            this.lblBalanceValue.Location = new System.Drawing.Point(80, 75);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(45, 19);
            this.lblBalanceValue.TabIndex = 4;
            this.lblBalanceValue.Text = "0,00€";

            // 
            // panelAccountActions
            // 
            this.panelAccountActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccountActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelAccountActions.Controls.Add(this.lblAccountActionsTitle);
            this.panelAccountActions.Controls.Add(this.btnEditProfile);
            this.panelAccountActions.Controls.Add(this.btnLogout);
            this.panelAccountActions.Controls.Add(this.btnDeleteAccount);
            this.panelAccountActions.Location = new System.Drawing.Point(30, 200);
            this.panelAccountActions.Name = "panelAccountActions";
            this.panelAccountActions.Size = new System.Drawing.Size(740, 150);
            this.panelAccountActions.TabIndex = 2;

            // 
            // lblAccountActionsTitle
            // 
            this.lblAccountActionsTitle.AutoSize = true;
            this.lblAccountActionsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountActionsTitle.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAccountActionsTitle.Location = new System.Drawing.Point(15, 10);
            this.lblAccountActionsTitle.Name = "lblAccountActionsTitle";
            this.lblAccountActionsTitle.Size = new System.Drawing.Size(115, 20);
            this.lblAccountActionsTitle.TabIndex = 0;
            this.lblAccountActionsTitle.Text = "AÇÕES DA CONTA";

            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnEditProfile.FlatAppearance.BorderSize = 0;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(20, 40);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(150, 40);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "✏️ Editar Perfil";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(190, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "🚪 Terminar Sessão";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(360, 40);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "🗑️ Excluir Conta";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);

            // 
            // panelEditProfile
            // 
            this.panelEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelEditProfile.Controls.Add(this.lblEditProfileTitle);
            this.panelEditProfile.Controls.Add(this.lblNewUsername);
            this.panelEditProfile.Controls.Add(this.txtNewUsername);
            this.panelEditProfile.Controls.Add(this.lblNewPassword);
            this.panelEditProfile.Controls.Add(this.txtNewPassword);
            this.panelEditProfile.Controls.Add(this.lblConfirmPassword);
            this.panelEditProfile.Controls.Add(this.txtConfirmPassword);
            this.panelEditProfile.Controls.Add(this.btnSaveChanges);
            this.panelEditProfile.Controls.Add(this.btnCancelEdit);
            this.panelEditProfile.Location = new System.Drawing.Point(30, 200);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(740, 260);
            this.panelEditProfile.TabIndex = 4;
            this.panelEditProfile.Visible = false;

            // 
            // lblEditProfileTitle
            // 
            this.lblEditProfileTitle.AutoSize = true;
            this.lblEditProfileTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEditProfileTitle.ForeColor = System.Drawing.Color.LightBlue;
            this.lblEditProfileTitle.Location = new System.Drawing.Point(15, 10);
            this.lblEditProfileTitle.Name = "lblEditProfileTitle";
            this.lblEditProfileTitle.Size = new System.Drawing.Size(125, 20);
            this.lblEditProfileTitle.TabIndex = 0;
            this.lblEditProfileTitle.Text = "EDITAR PERFIL";

            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewUsername.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewUsername.Location = new System.Drawing.Point(15, 45);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(134, 19);
            this.lblNewUsername.TabIndex = 1;
            this.lblNewUsername.Text = "Novo Utilizador:";

            // 
            // txtNewUsername
            // 
            this.txtNewUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNewUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewUsername.ForeColor = System.Drawing.Color.White;
            this.txtNewUsername.Location = new System.Drawing.Point(160, 43);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(250, 25);
            this.txtNewUsername.TabIndex = 2;

            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewPassword.Location = new System.Drawing.Point(15, 85);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(141, 19);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Nova Palavra-passe:";

            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.White;
            this.txtNewPassword.Location = new System.Drawing.Point(160, 83);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 25);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.UseSystemPasswordChar = true;

            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.LightGray;
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 125);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 19);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirmar Password:";

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(160, 123);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 25);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(160, 175);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "💾 Guardar";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);

            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Location = new System.Drawing.Point(290, 175);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(120, 40);
            this.btnCancelEdit.TabIndex = 8;
            this.btnCancelEdit.Text = "❌ Cancelar";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);

            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(30, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definições";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelNavSettings.ResumeLayout(false);
            this.panelNavSettings.PerformLayout();
            this.topBarPanel.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.panelAccountActions.ResumeLayout(false);
            this.panelAccountActions.PerformLayout();
            this.panelEditProfile.ResumeLayout(false);
            this.panelEditProfile.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}