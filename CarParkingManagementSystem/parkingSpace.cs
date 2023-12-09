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

namespace CarParkingManagementSystem
{
    public partial class parkingSpace : UserControl
    {
        Customer customer = new Customer();

        public parkingSpace()
        {
            InitializeComponent();
        }

        private string _idKH;
        private string _idSpace;
        private Image _icon;
        private Color _iconBg;

        [Category("Parking Space Props")]
        public string IDKH
        {
            get { return _idKH; }
            set { _idKH = value; }
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
            if (_iconBg == Color.LightGray)
            {
                MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (_iconBg == Color.White) 
            {
                DialogResult ans = MessageBox.Show("Đỗ xe ở vị trí này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {
                    customer.DoXe(IDSpace, IDKH, "chuatra");
                    MessageBox.Show("Đỗ xe thành công!");
                    IconBg = Color.LightGray;
                    Icon = Resources.car;
                }
            }    
        }
    }
}
