using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            formDB f2 = new formDB();
            f2.Show();
            Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            formAccount f3 = new formAccount();
            f3.Show();
            Visible = false;
        }
    }
}
