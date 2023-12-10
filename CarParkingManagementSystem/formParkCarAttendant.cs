using CarParkingManagementSystem.BSLayer;
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
    public partial class formParkCarAttendant : Form
    {
        Attendant attendant = new Attendant();

        public formParkCarAttendant()
        {
            InitializeComponent();
        }

        private string _idSpace;

        public string IDSpace
        {
            get { return _idSpace; }
            set { _idSpace = value; }
        }

        private string _idNV;

        public string IDNV
        {
            get { return _idNV; }
            set { _idNV = value; }
        }

        private void formParkCarAttendant_Load(object sender, EventArgs e)
        {
            this.txtIDDoxe.Text = IDSpace;
            this.txtIDKhachhang.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnParkcar_Click(object sender, EventArgs e)
        {
            attendant.DoXe(IDSpace, this.txtIDKhachhang.Text, "chuatra");
            MessageBox.Show("Đỗ xe thành công!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
