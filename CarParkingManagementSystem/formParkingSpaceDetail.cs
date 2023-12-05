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
    public partial class formParkingSpaceDetail : Form
    {
        public formParkingSpaceDetail()
        {
            InitializeComponent();
        }

        private void formParkingSpaceDetail_Load(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtIDKhachhang.Clear();
            this.txtIDNhanvien.Clear();
            this.txtTrangthai.Clear();
            this.txtGiatien.Clear();

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
