using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }

        private void formUser_Load(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtSDT.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.txtID.Enabled = true;
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtSDT.Enabled = true;

            this.txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.txtID.Enabled = false;
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtSDT.Enabled = false;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            formChangePassword form = new formChangePassword();
            form.ShowDialog();
        }
    }
}
