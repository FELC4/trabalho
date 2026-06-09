using System;
using System.Linq;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form4 : Form
    {
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Owner is Form3 ownerF3)
            {
                try
                {
                    if (!ownerF3.Visible) ownerF3.Show();
                    ownerF3.WindowState = FormWindowState.Normal;
                    ownerF3.BringToFront();
                    ownerF3.Activate();
                }
                catch { }
            }
            else
            {
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
                    catch { }
                }
            }

            this.Close();
        }
    }
}