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
    }
}
