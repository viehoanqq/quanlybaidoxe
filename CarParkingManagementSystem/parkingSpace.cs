using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CarParkingManagementSystem.Properties;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;
using CarParkingManagementSystem.BSLayer;
using System.IO;
using static CarParkingManagementSystem.DBLayer.IcallBack;

namespace CarParkingManagementSystem
{
    public partial class parkingSpace : UserControl
    {
        Customer customer = new Customer();
        IcallBack.IcallBackf _icallBackf = null;
        public parkingSpace(int type =1, IcallBack.IcallBackf callback = null)
        {
            InitializeComponent();
            typexe = type;// oto= 1 , xemay =2;
            _icallBackf = callback;
            txtdattruoc.Text = IsBooked ? "Đã được đặt trước" : "";
        }

        public void setdata(bool check)
        {
            txtdattruoc.Text = check ? "Đã được đặt trước" : "";
        } 


        private int typexe = 0;
        private int _flag;
        private string _idUser;
        private string _idSpace;
        private Image _icon;
        public int discount = 1;
        public bool IsBooked = false;
        private Color _iconBg;

        [Category("Parking Space Props")]
        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        [Category("Parking Space Props")]
        public string IDUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        [Category("Parking Space Props")]
        public string IDSpace
        {
            get { return _idSpace; }
            set { _idSpace = value; lblIDSpace.Text = value; }
        }

        [Category("Parking Space Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ptbParked.Image = value; }
        }

        [Category("Parking Space Props")]
        public Color IconBg
        {
            get { return _iconBg; }
            set { _iconBg = value; panel1.BackColor = value; }
        }

        private void parkingSpace_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightGray;
        }

        private void parkingSpace_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = _iconBg;
        }

        private void parkingSpace_Click(object sender, EventArgs e)
        {
            if (Flag == 0)
            {
                if (IsBooked)
                {
                    MessageBox.Show("Vị trí này đã được đặt trước!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                if (_iconBg == Color.LightGray)
                {
                    MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (_iconBg == Color.White)
                {
                    DialogResult choice = MessageBox.Show("Bạn muốn:\nYes: Gửi xe ngay\nNo: Đặt trước", "Chọn hành động", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (choice == DialogResult.Yes)
                    {
                        customer.DoXe(IDSpace, IDUser, "chuatra");
                        MessageBox.Show("Đỗ xe thành công!");
                        IconBg = Color.LightGray;
                        Icon = typexe == 1 ? Resources.car : Resources.xemay;

                        try
                        {
                            DataTable dt = customer.ThongtinDoxe(IDUser);
                            StreamWriter sw = new StreamWriter(Constant.Parth + IDSpace + ".txt");
                            float numbermew = 0;
                            try
                            {
                                numbermew = float.Parse(dt.Rows[0]["sotien"].ToString()) * (float)(discount / 100);
                            }
                            catch (Exception)
                            {
                                throw;
                            }

                            sw.WriteLine("-------------Vé gửi xe-----------");
                            sw.WriteLine("ID khách hàng: " + dt.Rows[0]["ID"].ToString());
                            sw.WriteLine("Tên khách hàng: " + dt.Rows[0]["ten"].ToString());
                            sw.WriteLine("Vị trí đỗ xe: " + IDSpace);
                            sw.WriteLine("Biển số xe: " + dt.Rows[0]["bienSo"].ToString());
                            sw.WriteLine("Ngày đỗ xe: " + dt.Rows[0]["ngayDoXe"].ToString());
                            sw.WriteLine("Ngày lấy xe: " + dt.Rows[0]["ngayLayXe"].ToString());
                            sw.WriteLine("Phí đỗ xe: " + numbermew.ToString() + "đ");
                            sw.WriteLine("---------------------------------");
                            sw.Close();
                            MessageBox.Show("Đã in vé!");
                            _icallBackf?.Invoke();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("In vé thất bại!\n" + ex.Message);
                        }
                    }
                    else if (choice == DialogResult.No)
                    {
                        customer.DatTruocChoNgoi(IDSpace, IDUser);
                        MessageBox.Show("Đặt trước vị trí thành công!");
                    }
                }
            }

            if (Flag == 1)
            {
                if (_iconBg == Color.LightGray)
                {
                    MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (_iconBg == Color.White)
                {
                    DialogResult ans = MessageBox.Show("Đỗ xe ở vị trí này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {
                        formParkCarAttendant form = new formParkCarAttendant();
                        form.IDSpace = IDSpace;
                        form.IDNV = IDUser;
                        form.Show();
                        IconBg = Color.LightGray;
                        Icon = Resources.car;
                    }
                }
            }
        }
    }
}
