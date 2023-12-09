using CarParkingManagementSystem.Properties;
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
    public partial class formParkingInformation : Form
    {
        public formParkingInformation()
        {
            InitializeComponent();
        }

        private void formParkingInformation_Load(object sender, EventArgs e)
        {
            parkingLot();
        }

        private void parkingLot()
        {
            parked.ID = "ID Space";
            parked.Icon = Resources.car;
            parked.IconBg = Color.Gainsboro;            
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            formPayment form = new formPayment();
            form.ShowDialog();
        }
    }
}
