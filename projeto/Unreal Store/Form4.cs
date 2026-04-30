using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form4 : Form
    {
        // True when the user chose "Logout"
        public bool IsLogout { get; private set; }

        public Form4()
        {
            InitializeComponent();

            // Ensure click handlers are attached (safe if designer didn't wire them)
            this.button2.Click -= button2_Click;
            this.button2.Click += button2_Click;

            this.button1.Click -= button1_Click;
            this.button1.Click += button1_Click;
        }

        // Logout: show Form1, close Form3, set flag and close this form
        private void button2_Click(object sender, EventArgs e)
        {
            // Show existing Form1 (or create a new one)
            var f1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (f1 != null)
            {
                if (!f1.Visible) f1.Show();
                f1.WindowState = FormWindowState.Normal;
                try
                {
                    f1.BringToFront();
                    f1.Activate();
                }
                catch { /* non-fatal if fails */ }
            }
            else
            {
                var newF1 = new Form1();
                newF1.Show();
            }

            // Close Form3 if present
            var f3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            if (f3 != null)
            {
                try { f3.Close(); } catch { }
            }

            IsLogout = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Sair: exit application
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
