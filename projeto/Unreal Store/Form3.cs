using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form3 : Form
    {
        private string currentUsername;
        private decimal sessionBalance = 0m;
        private Control[] storeControls;
        private Control[] updateControls = Array.Empty<Control>();

        public Form3()
        {
            InitializeComponent();

            // wire sidebar clicks
            panelNavStore.Click += (s, e) => ShowStore();
            lblStoreIcon.Click += (s, e) => ShowStore();
            lblStoreText.Click += (s, e) => ShowStore();

            panelNavLibrary.Click += (s, e) => ShowLibrary();
            lblLibraryIcon.Click += (s, e) => ShowLibrary();
            lblLibraryText.Click += (s, e) => ShowLibrary();

            panelNavEngine.Click += (s, e) => ShowUpdate();
            lblEngineIcon.Click += (s, e) => ShowUpdate();
            lblEngineText.Click += (s, e) => ShowUpdate();

            // capture store controls for hide/show
            storeControls = new Control[]
            {
                mainContentLabel,
                button1, button2, button3, button4,
                label2,label3,label4,label5,label6,label7,label8,label9
            };

            ShowStore();
            UpdateBalanceDisplay();
        }

        // set authenticated user and refresh balance
        public string Username
        {
            set
            {
                currentUsername = value;
                UpdateBalanceDisplay();
            }
        }

        private void UpdateBalanceDisplay()
        {
            decimal displayAmount;
            if (string.IsNullOrWhiteSpace(currentUsername))
            {
                displayAmount = sessionBalance;
            }
            else
            {
                displayAmount = AccountStore.GetBalance(currentUsername);
            }

            lblBalance.Text = displayAmount.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"));
        }

        // show the original store layout (designer controls)
        private void ShowStore()
        {
            // ensure store controls visible
            foreach (var c in storeControls) c.Visible = true;
            // remove update controls if present
            foreach (var c in updateControls) if (mainContentPanel.Controls.Contains(c)) mainContentPanel.Controls.Remove(c);
            updateControls = Array.Empty<Control>();

            // highlight sidebar visual
            panelNavStore.BackColor = Color.FromArgb(48, 48, 48);
            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);

            mainContentLabel.Text = "Loja";
        }

        private void ShowLibrary()
        {
            foreach (var c in storeControls) c.Visible = false;
            foreach (var c in updateControls) if (mainContentPanel.Controls.Contains(c)) mainContentPanel.Controls.Remove(c);
            updateControls = Array.Empty<Control>();

            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            panelNavLibrary.BackColor = Color.FromArgb(48, 48, 48);
            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);

            mainContentLabel.Text = "Biblioteca";
            mainContentPanel.Controls.Add(new Label() { Text = "Os seus jogos aparecerão aqui.", ForeColor = Color.LightGray, Location = new Point(20, 60), AutoSize = true });
        }

        private void ShowUpdate()
        {
            foreach (var c in storeControls) c.Visible = false;
            foreach (var c in updateControls) if (mainContentPanel.Controls.Contains(c)) mainContentPanel.Controls.Remove(c);

            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            panelNavEngine.BackColor = Color.FromArgb(48, 48, 48);

            mainContentLabel.Text = "Atualizar - Adicionar Fundos";

            var lblInfo = new Label() { Text = "Valor a adicionar (€):", ForeColor = Color.LightGray, Location = new Point(20, 60), AutoSize = true };
            var tbAmount = new TextBox() { Location = new Point(20, 88), Size = new Size(120, 24), Text = "0,00" };
            var btnAdd = new Button() { Text = "Adicionar", Location = new Point(150, 86), Size = new Size(100, 26), BackColor = Color.FromArgb(70, 130, 180), FlatStyle = FlatStyle.Flat, ForeColor = Color.White };

            btnAdd.Click += (s, e) =>
            {
                if (!decimal.TryParse(tbAmount.Text.Trim(), NumberStyles.Number, CultureInfo.GetCultureInfo("pt-PT"), out var amount))
                {
                    if (!decimal.TryParse(tbAmount.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out amount))
                    {
                        MessageBox.Show("Valor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Insira um valor maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(currentUsername))
                {
                    sessionBalance += amount;
                }
                else
                {
                    AccountStore.AddFunds(currentUsername, amount);
                }

                UpdateBalanceDisplay();
                MessageBox.Show($"Foram adicionados {amount.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))} à carteira.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            mainContentPanel.Controls.Add(lblInfo);
            mainContentPanel.Controls.Add(tbAmount);
            mainContentPanel.Controls.Add(btnAdd);

            updateControls = new Control[] { lblInfo, tbAmount, btnAdd };
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            decimal price = 0m;
            string title = "Jogo";

            if (sender == button1) { price = 19.99m; title = "Jogo de Ação"; }
            else if (sender == button2) { price = 9.99m; title = "Jogo de Exploração"; }
            else if (sender == button3) { price = 3.99m; title = "Point-and-Click 2D"; }
            else if (sender == button4) { price = 0m; title = "Multi-jogador"; }

            var priceText = price > 0 ? price.ToString("C2", CultureInfo.GetCultureInfo("pt-PT")) : "Gratuito";
            var msg = price > 0 ? $"Comprar '{title}' por {priceText}?" : $"'{title}' é gratuito. Deseja adicionar à sua biblioteca?";
            var res = MessageBox.Show(msg, "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;

            if (price <= 0m)
            {
                MessageBox.Show("Item adicionado à sua biblioteca (simulação).", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // attempt to deduct from authenticated account first
            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                var success = AccountStore.TrySpend(currentUsername, price);
                if (success)
                {
                    UpdateBalanceDisplay();
                    MessageBox.Show("Compra efectuada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var ask = MessageBox.Show("Saldo insuficiente. Deseja adicionar fundos agora?", "Saldo insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ask == DialogResult.Yes) ShowUpdate();
                    return;
                }
            }

            // anonymous session wallet
            if (sessionBalance >= price)
            {
                sessionBalance -= price;
                UpdateBalanceDisplay();
                MessageBox.Show("Compra efectuada com sucesso (sessão).", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var ask = MessageBox.Show("Saldo de sessão insuficiente. Deseja adicionar fundos agora?", "Saldo insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ask == DialogResult.Yes) ShowUpdate();
            }
        }

        // bottomDot opens settings (Form4)
        private void bottomDot_Click(object sender, EventArgs e)
        {
            using (var f4 = new Form4())
            {
                this.Hide();
                f4.ShowDialog(this);
                if (!this.IsDisposed) this.Show();
            }
            UpdateBalanceDisplay();
        }

        private void bottomDot_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var rc = (sender as Control)?.ClientRectangle ?? new Rectangle(0, 0, 16, 16);
            var cx = rc.Width / 2;
            var cy = rc.Height / 2;
            var r = Math.Min(rc.Width, rc.Height) / 4;
            using (var brush = new SolidBrush(Color.FromArgb(64, 184, 255)))
            {
                g.FillEllipse(brush, cx - r, cy - r, r * 2, r * 2);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panelNavLibrary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}      