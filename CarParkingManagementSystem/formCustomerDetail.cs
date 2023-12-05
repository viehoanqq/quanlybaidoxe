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
    public partial class formCustomerDetail : Form
    {
        public formCustomerDetail()
        {
            InitializeComponent();
        }

        private void formCustomerDetail_Load(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtAge.Clear();
            this.txtSDT.Clear();
            this.txtAddress.Clear();
            this.txtBienso.Clear();
            this.txtNgaydoxe.Clear();
            this.txtNgaylayxe.Clear();
            this.txtPhidoxe.Clear();

            this.txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
