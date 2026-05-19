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
        private System.Windows.Forms.Panel mainContentPanel;
        private System.Windows.Forms.Label mainContentLabel;
        private System.Windows.Forms.Panel bottomDot;

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
            this.bottomDot = new System.Windows.Forms.Panel();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.mainContentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelNavStore.SuspendLayout();
            this.panelNavLibrary.SuspendLayout();
            this.panelNavEngine.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panelSidebar.Controls.Add(this.panelNavStore);
            this.panelSidebar.Controls.Add(this.panelNavLibrary);
            this.panelSidebar.Controls.Add(this.panelNavEngine);
            this.panelSidebar.Controls.Add(this.bottomDot);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
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
            // bottomDot
            // 
            this.bottomDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bottomDot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomDot.Location = new System.Drawing.Point(16, 520);
            this.bottomDot.Name = "bottomDot";
            this.bottomDot.Size = new System.Drawing.Size(36, 36);
            this.bottomDot.TabIndex = 3;
            this.bottomDot.Click += new System.EventHandler(this.bottomDot_Click);
            this.bottomDot.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomDot_Paint);
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainContentPanel.Controls.Add(this.label12);
            this.mainContentPanel.Controls.Add(this.label11);
            this.mainContentPanel.Controls.Add(this.label10);
            this.mainContentPanel.Controls.Add(this.label9);
            this.mainContentPanel.Controls.Add(this.label8);
            this.mainContentPanel.Controls.Add(this.label7);
            this.mainContentPanel.Controls.Add(this.label6);
            this.mainContentPanel.Controls.Add(this.label5);
            this.mainContentPanel.Controls.Add(this.label4);
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.label2);
            this.mainContentPanel.Controls.Add(this.label1);
            this.mainContentPanel.Controls.Add(this.button4);
            this.mainContentPanel.Controls.Add(this.button3);
            this.mainContentPanel.Controls.Add(this.button2);
            this.mainContentPanel.Controls.Add(this.button1);
            this.mainContentPanel.Controls.Add(this.mainContentLabel);
            this.mainContentPanel.Location = new System.Drawing.Point(200, 48);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(800, 540);
            this.mainContentPanel.TabIndex = 1;
            // 
            // mainContentLabel
            // 
            this.mainContentLabel.AutoSize = true;
            this.mainContentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.mainContentLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainContentLabel.Location = new System.Drawing.Point(20, 10);
            this.mainContentLabel.Name = "mainContentLabel";
            this.mainContentLabel.Size = new System.Drawing.Size(65, 30);
            this.mainContentLabel.TabIndex = 0;
            this.mainContentLabel.Text = "Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jogo de Ação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(212, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jogo de Exploração";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(390, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Point-and-Click 2D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(568, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jogo Multi-jogador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(35, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jogo Base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(213, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jogo Base";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(394, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jogo Base";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(569, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jogo Base";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(33, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "19,99€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(211, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "9,99€";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(389, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "3,99€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(567, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Gratuito";
            // 
            // button4
            // 
            this.button4.Image = global::Unreal_Store.Properties.Resources.Albion_Online__1_;
            this.button4.Location = new System.Drawing.Point(572, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 234);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Unreal_Store.Properties.Resources.Five_Nights_at_Freddys_For_the_Fans_scaled__1___2_;
            this.button3.Location = new System.Drawing.Point(394, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 234);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Unreal_Store.Properties.Resources.cb6290ec436941da956f4a6080a29d22__2___1___2_;
            this.button2.Location = new System.Drawing.Point(216, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 234);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Unreal_Store.Properties.Resources.The_Last_of_Us_Part_I__2_;
            this.button1.Location = new System.Drawing.Point(38, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 234);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.mainContentPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form3";
            this.Text = "Store";
            this.panelSidebar.ResumeLayout(false);
            this.panelNavStore.ResumeLayout(false);
            this.panelNavStore.PerformLayout();
            this.panelNavLibrary.ResumeLayout(false);
            this.panelNavLibrary.PerformLayout();
            this.panelNavEngine.ResumeLayout(false);
            this.panelNavEngine.PerformLayout();
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}