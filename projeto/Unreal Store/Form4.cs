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

            this.button1.Click -= button1_Click;
            this.button1.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Voltar: reexibir Form3 e fechar Form4
        private void button2_Click(object sender, EventArgs e)
        {
            // If Form4 was opened modal with Form3 as owner (ShowDialog(this)),
            // Owner will be the Form3 instance.
            if (this.Owner is Form3 ownerF3)
            {
                try
                {
                    if (!ownerF3.Visible) ownerF3.Show();
                    ownerF3.WindowState = FormWindowState.Normal;
                    ownerF3.BringToFront();
                    ownerF3.Activate();
                }
                catch { /* non-fatal */ }
            }
            else
            {
                // Fallback: find any open Form3 and show it
                var openF3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
                if (openF3 != null)
                {
                    try
                    {
                        if (!openF3.Visible) openF3.Show();
                        openF3.WindowState = FormWindowState.Normal;
                        openF3.BringToFront();
                        openF3.Activate();
                    }
                    catch { /* non-fatal */ }
                }
            }

            this.Close();
        }
    }
}