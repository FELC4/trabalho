using Unreal_Store;

namespace Unreal_Store
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelNavStore;
        private System.Windows.Forms.Label lblStoreIcon;
        private System.Windows.Forms.Label lblStoreText;
        private System.Windows.Forms.Panel panelNavLibrary;
        private System.Windows.Forms.Label lblLibraryIcon;
        private System.Windows.Forms.Label lblLibraryText;
        private System.Windows.Forms.Panel panelNavEngine;
        private System.Windows.Forms.Label lblEngineIcon;
        private System.Windows.Forms.Label lblEngineText;
        private System.Windows.Forms.Panel panelNavSettings;
        private System.Windows.Forms.Label lblSettingsIcon;
        private System.Windows.Forms.Label lblSettingsText;
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label mainContentLabel;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label lblBalance;
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
            this.panelNavStore = new System.Windows.Forms.Panel();
            this.lblStoreIcon = new System.Windows.Forms.Label();
            this.lblStoreText = new System.Windows.Forms.Label();
            this.panelNavLibrary = new System.Windows.Forms.Panel();
            this.lblLibraryIcon = new System.Windows.Forms.Label();
            this.lblLibraryText = new System.Windows.Forms.Label();
            this.panelNavEngine = new System.Windows.Forms.Panel();
            this.lblEngineIcon = new System.Windows.Forms.Label();
            this.lblEngineText = new System.Windows.Forms.Label();
            this.panelNavSettings = new System.Windows.Forms.Panel();
            this.lblSettingsIcon = new System.Windows.Forms.Label();
            this.lblSettingsText = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.mainContentLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelSidebar.SuspendLayout();
            this.panelNavStore.SuspendLayout();
            this.panelNavLibrary.SuspendLayout();
            this.panelNavEngine.SuspendLayout();
            this.panelNavSettings.SuspendLayout();
            this.topBarPanel.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
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
            this.panelSidebar.Controls.Add(this.panelNavStore);
            this.panelSidebar.Controls.Add(this.panelNavLibrary);
            this.panelSidebar.Controls.Add(this.panelNavEngine);
            this.panelSidebar.Controls.Add(this.panelNavSettings);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.Name = "panelSidebar";
            this.mainLayout.SetRowSpan(this.panelSidebar, 2);
            this.panelSidebar.Size = new System.Drawing.Size(200, 600);
            this.panelSidebar.TabIndex = 0;

            // 
            // panelNavStore
            // 
            this.panelNavStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelNavStore.Controls.Add(this.lblStoreIcon);
            this.panelNavStore.Controls.Add(this.lblStoreText);
            this.panelNavStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavStore.Location = new System.Drawing.Point(8, 30);
            this.panelNavStore.Name = "panelNavStore";
            this.panelNavStore.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.panelNavStore.Size = new System.Drawing.Size(184, 56);
            this.panelNavStore.TabIndex = 0;

            // 
            // lblStoreIcon
            // 
            this.lblStoreIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblStoreIcon.ForeColor = System.Drawing.Color.White;
            this.lblStoreIcon.Location = new System.Drawing.Point(12, 16);
            this.lblStoreIcon.Name = "lblStoreIcon";
            this.lblStoreIcon.Size = new System.Drawing.Size(24, 24);
            this.lblStoreIcon.TabIndex = 0;
            this.lblStoreIcon.Text = "🛍";
            this.lblStoreIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblStoreText
            // 
            this.lblStoreText.AutoSize = true;
            this.lblStoreText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStoreText.ForeColor = System.Drawing.Color.White;
            this.lblStoreText.Location = new System.Drawing.Point(48, 18);
            this.lblStoreText.Name = "lblStoreText";
            this.lblStoreText.Size = new System.Drawing.Size(34, 19);
            this.lblStoreText.TabIndex = 1;
            this.lblStoreText.Text = "Loja";

            // 
            // panelNavLibrary
            // 
            this.panelNavLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelNavLibrary.Controls.Add(this.lblLibraryIcon);
            this.panelNavLibrary.Controls.Add(this.lblLibraryText);
            this.panelNavLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavLibrary.Location = new System.Drawing.Point(8, 94);
            this.panelNavLibrary.Name = "panelNavLibrary";
            this.panelNavLibrary.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.panelNavLibrary.Size = new System.Drawing.Size(184, 56);
            this.panelNavLibrary.TabIndex = 1;

            // 
            // lblLibraryIcon
            // 
            this.lblLibraryIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblLibraryIcon.ForeColor = System.Drawing.Color.LightGray;
            this.lblLibraryIcon.Location = new System.Drawing.Point(12, 16);
            this.lblLibraryIcon.Name = "lblLibraryIcon";
            this.lblLibraryIcon.Size = new System.Drawing.Size(24, 24);
            this.lblLibraryIcon.TabIndex = 0;
            this.lblLibraryIcon.Text = "📚";
            this.lblLibraryIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblLibraryText
            // 
            this.lblLibraryText.AutoSize = true;
            this.lblLibraryText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLibraryText.ForeColor = System.Drawing.Color.LightGray;
            this.lblLibraryText.Location = new System.Drawing.Point(48, 18);
            this.lblLibraryText.Name = "lblLibraryText";
            this.lblLibraryText.Size = new System.Drawing.Size(67, 19);
            this.lblLibraryText.TabIndex = 1;
            this.lblLibraryText.Text = "Biblioteca";

            // 
            // panelNavEngine
            // 
            this.panelNavEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelNavEngine.Controls.Add(this.lblEngineIcon);
            this.panelNavEngine.Controls.Add(this.lblEngineText);
            this.panelNavEngine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavEngine.Location = new System.Drawing.Point(8, 158);
            this.panelNavEngine.Name = "panelNavEngine";
            this.panelNavEngine.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.panelNavEngine.Size = new System.Drawing.Size(184, 56);
            this.panelNavEngine.TabIndex = 2;

            // 
            // lblEngineIcon
            // 
            this.lblEngineIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblEngineIcon.ForeColor = System.Drawing.Color.LightGray;
            this.lblEngineIcon.Location = new System.Drawing.Point(12, 16);
            this.lblEngineIcon.Name = "lblEngineIcon";
            this.lblEngineIcon.Size = new System.Drawing.Size(24, 24);
            this.lblEngineIcon.TabIndex = 0;
            this.lblEngineIcon.Text = "⚙️";
            this.lblEngineIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblEngineText
            // 
            this.lblEngineText.AutoSize = true;
            this.lblEngineText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEngineText.ForeColor = System.Drawing.Color.LightGray;
            this.lblEngineText.Location = new System.Drawing.Point(48, 18);
            this.lblEngineText.Name = "lblEngineText";
            this.lblEngineText.Size = new System.Drawing.Size(62, 19);
            this.lblEngineText.TabIndex = 1;
            this.lblEngineText.Text = "Atualizar";

            // 
            // panelNavSettings
            // 
            this.panelNavSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelNavSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelNavSettings.Controls.Add(this.lblSettingsIcon);
            this.panelNavSettings.Controls.Add(this.lblSettingsText);
            this.panelNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNavSettings.Location = new System.Drawing.Point(8, 500);
            this.panelNavSettings.Name = "panelNavSettings";
            this.panelNavSettings.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.panelNavSettings.Size = new System.Drawing.Size(184, 56);
            this.panelNavSettings.TabIndex = 4;

            // 
            // lblSettingsIcon
            // 
            this.lblSettingsIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.lblSettingsIcon.ForeColor = System.Drawing.Color.LightGray;
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
            this.lblSettingsText.ForeColor = System.Drawing.Color.LightGray;
            this.lblSettingsText.Location = new System.Drawing.Point(48, 18);
            this.lblSettingsText.Name = "lblSettingsText";
            this.lblSettingsText.Size = new System.Drawing.Size(75, 19);
            this.lblSettingsText.TabIndex = 1;
            this.lblSettingsText.Text = "Definições";

            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.topBarPanel.Controls.Add(this.lblBalance);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBarPanel.Location = new System.Drawing.Point(200, 0);
            this.topBarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(800, 48);
            this.topBarPanel.TabIndex = 1;

            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBalance.Location = new System.Drawing.Point(700, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(100, 25);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "€0,00";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainContentPanel.Controls.Add(this.mainContentLabel);
            this.mainContentPanel.Controls.Add(this.label9);
            this.mainContentPanel.Controls.Add(this.label8);
            this.mainContentPanel.Controls.Add(this.label7);
            this.mainContentPanel.Controls.Add(this.label6);
            this.mainContentPanel.Controls.Add(this.label5);
            this.mainContentPanel.Controls.Add(this.label4);
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.label2);
            this.mainContentPanel.Controls.Add(this.button4);
            this.mainContentPanel.Controls.Add(this.button3);
            this.mainContentPanel.Controls.Add(this.button2);
            this.mainContentPanel.Controls.Add(this.button1);
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
            this.mainContentLabel.Size = new System.Drawing.Size(54, 30);
            this.mainContentLabel.TabIndex = 0;
            this.mainContentLabel.Text = "Loja";

            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(544, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Gratuito";

            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(370, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "3,99€";

            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(195, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "9,99€";

            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(21, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "19,99€";

            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(544, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jogo Multi-jogador";

            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(370, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Point and Click 2D";

            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(196, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jogo de Exploração";

            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jogo de Ação";

            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Image = global::Unreal_Store.Properties.Resources.multijogador;
            this.button4.Location = new System.Drawing.Point(547, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 250);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GameButton_Click);

            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Image = global::Unreal_Store.Properties.Resources.pac2d;
            this.button3.Location = new System.Drawing.Point(373, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 250);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GameButton_Click);

            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Image = global::Unreal_Store.Properties.Resources.jogoExploracao;
            this.button2.Location = new System.Drawing.Point(199, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 250);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GameButton_Click);

            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Image = global::Unreal_Store.Properties.Resources.jogoAcao;
            this.button1.Location = new System.Drawing.Point(25, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 250);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GameButton_Click);

            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelNavStore.ResumeLayout(false);
            this.panelNavStore.PerformLayout();
            this.panelNavLibrary.ResumeLayout(false);
            this.panelNavLibrary.PerformLayout();
            this.panelNavEngine.ResumeLayout(false);
            this.panelNavEngine.PerformLayout();
            this.panelNavSettings.ResumeLayout(false);
            this.panelNavSettings.PerformLayout();
            this.topBarPanel.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}