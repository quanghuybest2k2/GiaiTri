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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbbSelectLab.SelectedIndex = 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void SelectLab()
        {
            switch (cbbSelectLab.SelectedIndex)
            {
                case 0:
                    ShowForm(new frmLab1());
                    break;
                case 1:
                   ShowForm(new frmLab2());
                    break;

            }
        }
        private void ShowForm(Form form)
        {
            form.Owner = this; // ủy quyền cho frmMain 
            form.ShowDialog();
            //this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SelectLab();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy bỏ sự kiện đóng form
            }
        }
    }
}
