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
    public partial class parkingSpace : UserControl
    {
        public parkingSpace()
        {
            InitializeComponent();
        }

        private string _id;
        private Image _icon;
        private Color _iconBg;

        [Category("Parking Space Props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; lblIDSpace.Text = value; }
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
            this.BackColor = Color.LightGray;
        }

        private void parkingSpace_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void parkingSpace_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.LightGray)
            {
                MessageBox.Show("Vị trí này đã có xe khác đỗ!", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Đỗ xe ở vị trí này?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }    
        }
    }
}
