using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovićBudićProjektRP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btBlagajna_Click(object sender, EventArgs e)
        {
            LoginBlagajna loginBlagajna=new LoginBlagajna();
            loginBlagajna.Show();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
        }

        private void btObracun_Click(object sender, EventArgs e)
        {
            LoginObracun loginObracun=new LoginObracun();
            loginObracun.Show();
        }
    }
}
