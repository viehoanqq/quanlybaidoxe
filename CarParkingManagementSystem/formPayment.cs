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
    public partial class formPayment : Form
    {
        public formPayment()
        {
            InitializeComponent();
        }
        private void formPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTienmat_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.Silver;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.Silver;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
        }

        private void btnVidientu_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.Silver;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
        }

        private void btnChuyenkhoan_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.Silver;
        }
    }
}
