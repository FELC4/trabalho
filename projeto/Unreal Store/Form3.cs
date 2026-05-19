using System;
using System.Drawing;
using System.Windows.Forms;
using Unreal_Store;
using System.Linq;

namespace Unreal_Store
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            panelNavStore.Click += NavStore_Click;
            lblStoreIcon.Click += NavStore_Click;
            lblStoreText.Click += NavStore_Click;

            panelNavLibrary.Click += NavLibrary_Click;
            lblLibraryIcon.Click += NavLibrary_Click;
            lblLibraryText.Click += NavLibrary_Click;

            panelNavEngine.Click += NavEngine_Click;
            lblEngineIcon.Click += NavEngine_Click;
            lblEngineText.Click += NavEngine_Click;

            SelectNav("Loja");
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

        private void bottomDot_Click(object sender, EventArgs e)
        {
            using (var f4 = new Form4())
            {
                this.Hide();
                f4.ShowDialog(this);
                if (!this.IsDisposed)
                    this.Show();
            }
        }

        private void NavStore_Click(object sender, EventArgs e) => SelectNav("Loja");
        private void NavLibrary_Click(object sender, EventArgs e) => SelectNav("Biblioteca");
        private void NavEngine_Click(object sender, EventArgs e) => SelectNav("Atualizar");

        private void SelectNav(string key)
        {
        
            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            lblStoreText.ForeColor = Color.LightGray;
            lblStoreIcon.ForeColor = Color.LightGray;

            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            lblLibraryText.ForeColor = Color.LightGray;
            lblLibraryIcon.ForeColor = Color.LightGray;

            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);
            lblEngineText.ForeColor = Color.LightGray;
            lblEngineIcon.ForeColor = Color.LightGray;

            if (key == "Loja")
            {
                panelNavStore.BackColor = Color.FromArgb(48, 48, 48);
                lblStoreText.ForeColor = Color.White;
                lblStoreIcon.ForeColor = Color.White;
                mainContentLabel.Text = "Loja";
            }
            else if (key == "Biblioteca")
            {
                panelNavLibrary.BackColor = Color.FromArgb(48, 48, 48);
                lblLibraryText.ForeColor = Color.White;
                lblLibraryIcon.ForeColor = Color.White;
                mainContentLabel.Text = "Biblioteca";
            }
            else if (key == "Atualizar")
            {
                panelNavEngine.BackColor = Color.FromArgb(48, 48, 48);
                lblEngineText.ForeColor = Color.White;
                lblEngineIcon.ForeColor = Color.White;
                mainContentLabel.Text = "Atualizar";
            }
        }

        private void button2_Click(object sender, EventArgs e) { /* placeholder */ }
        private void button4_Click(object sender, EventArgs e)
        {
            using (var f4 = new Form4())
            {
                this.Hide();
                f4.ShowDialog(this);
                if (!this.IsDisposed)
                    this.Show();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}