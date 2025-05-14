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
    public partial class formPayment : Form
    {
        Customer customer = new Customer();
        public string IDKH;

        public formPayment(string id)
        {
            InitializeComponent();
            IDKH = id;
        }

        public void LoadData()
        {
            DataTable dt = customer.ThongtinDoxe(IDKH);
            this.txtID.Text = dt.Rows[0]["ID"].ToString();
            this.txtName.Text = dt.Rows[0]["ten"].ToString();
            this.txtBienso.Text = dt.Rows[0]["bienSo"].ToString();
            this.txtNgaydoxe.Text = dt.Rows[0]["ngayDoXe"].ToString();
            this.txtNgaylayxe.Text = dt.Rows[0]["ngayLayXe"].ToString();
            this.txtPhidoxe.Text = dt.Rows[0]["sotien"].ToString();
        }

        private void formPayment_Load(object sender, EventArgs e)
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

        private void btnTienmat_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.Silver;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
            btnThanhtoan.Enabled = true;
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.Silver;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
            btnThanhtoan.Enabled = true;
        }

        private void btnVidientu_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.Silver;
            btnChuyenkhoan.BackColor = Color.WhiteSmoke;
            btnThanhtoan.Enabled = true;
        }

        private void btnChuyenkhoan_Click(object sender, EventArgs e)
        {
            btnTienmat.BackColor = Color.WhiteSmoke;
            btnInternet.BackColor = Color.WhiteSmoke;
            btnVidientu.BackColor = Color.WhiteSmoke;
            btnChuyenkhoan.BackColor = Color.Silver;
            btnThanhtoan.Enabled = true;
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            string jkhj = IDKH;
            //customer.LayXe(customer.ViTriDoXe(IDKH).ToString());
            //MessageBox.Show("Thanh toán thành công!");
            //MessageBox.Show("Lấy xe thành công!");
            string idDoXe = customer.ViTriDoXemew(IDKH);
            if (idDoXe != null)
            {
                bool success = customer.LayXe(idDoXe);
                if (success)
                {
                    MessageBox.Show("Lấy xe thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật cơ sở dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy vị trí đỗ xe của bạn.");
            }
            this.Close();
        }
    }
}
