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
    public partial class formReport : Form
    {
        Manager manager = new Manager();
        public formReport()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                DataTable dt = manager.GetAllInfoDoXe();
                this.dtgReport.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể hiển thị dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
