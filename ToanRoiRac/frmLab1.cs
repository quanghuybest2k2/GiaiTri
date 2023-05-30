using ToanRoiRac.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanRoiRac
{
    public partial class frmLab1 : Form
    {
        private Lab1 lab1;
        public frmLab1()
        {
            InitializeComponent();
            lab1 = new Lab1();
            cbbChoice.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            if (cbbChoice.SelectedIndex == 0)
            {
                lab1.choice(0);
            }
            else if (cbbChoice.SelectedIndex == 1)
            {
                lab1.choice(1);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
