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
    public partial class formParkingLot : Form
    {
        Customer customer = new Customer();
        public string ID;

        public formParkingLot(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void formParkingLot_Load(object sender, EventArgs e)
        {
            parkingLot();
        }

        private void parkingLot()
        {
            DataTable dt = new DataTable();
            dt = customer.BaiDoXe();
            int numOfSpace = int.Parse(customer.NumOfSpace().ToString());
            parkingSpace[] parkingSpaces = new parkingSpace[100];

            for (int i = 0; i < numOfSpace; i++)
            {
                if (dt.Rows[i]["IDNguoiDung"].ToString().Trim() == string.Empty)
                {
                    parkingSpaces[i] = new parkingSpace();
                    parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
                    parkingSpaces[i].IconBg = Color.White;
                    parkingSpaces[i].IDKH = ID;
                }
                else
                {
                    parkingSpaces[i] = new parkingSpace();
                    parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
                    parkingSpaces[i].Icon = Resources.car;
                    parkingSpaces[i].IconBg = Color.LightGray;
                    parkingSpaces[i].IDKH = ID;
                }

                if (layoutPnl.Controls.Count < 0)
                    layoutPnl.Controls.Clear();
                else
                    layoutPnl.Controls.Add(parkingSpaces[i]);
            }
        }
    }
}
