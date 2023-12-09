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
    public partial class formParkingSpace : Form
    {
        Manager manager = new Manager();
        public formParkingSpace()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                dtgChitietBaidoxe.DataSource = manager.GetNoiDoXe();
                // Đếm số dòng của datagridview để gán cho label
                int num = dtgChitietBaidoxe.Rows.Count;
                this.lb_SoLuongBaiDo.Text = (num - 1).ToString();
                this.lb_SoXeDaTra.Text = manager.GetTraNoiDoXe().ToString();
                if (manager.SoTienDaTra().ToString() == "")
                {
                    this.lb_SoTienDaTra.Text = "0";
                }
                else
                {
                    this.lb_SoTienDaTra.Text = manager.SoTienDaTra().ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            formParkingSpaceDetail form = new formParkingSpaceDetail();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formParkingSpaceDetail form = new formParkingSpaceDetail();
            form.ShowDialog();
        }

        private void formParkingSpace_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = manager.TimKiemNoiDoXe(txtFind.Text);
                dtgChitietBaidoxe.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
