using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;
using CarParkingManagementSystem.BSLayer;

namespace CarParkingManagementSystem
{
    public partial class formUser : Form
    {
        Manager manager = new Manager();
        public formUser()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                DataTable dataTable = manager.GetAllAdminInfo();
                this.txtID.Text = dataTable.Rows[0]["ID"].ToString();
                this.txtName.Text = dataTable.Rows[0]["ten"].ToString();
                this.txtAge.Text = dataTable.Rows[0]["tuoi"].ToString();
                this.txtAddress.Text = dataTable.Rows[0]["diachi"].ToString();
                this.txtSDT.Text = dataTable.Rows[0]["sdt"].ToString();
                this.txtID.Enabled = false;
                this.txtName.Enabled = false;
                this.txtAge.Enabled = false;
                this.txtAddress.Enabled = false;
                this.txtSDT.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void formUser_Load(object sender, EventArgs e)
        {
            LoadData();
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
            this.txtID.Enabled = false;
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtAddress.Enabled = true;
            this.txtSDT.Enabled = true;
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
