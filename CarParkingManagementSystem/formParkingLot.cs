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

namespace CarParkingManagementSystem
{
    public partial class formParkingLot : Form
    {
        public formParkingLot()
        {
            InitializeComponent();
        }

        private void formParkingLot_Load(object sender, EventArgs e)
        {
            parkingLot();
        }

        private void parkingLot()
        {
            parkingSpace[] parkingSpaces = new parkingSpace[20];

            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (i == 1 || i == 3 || i == 4 || i == 7 || i == 9 || i == 10 || i == 11 || i == 14 || i == 15 || i == 20)
                {
                    parkingSpaces[i] = new parkingSpace();
                    parkingSpaces[i].ID = "ID Space";
                }
                else
                {
                    parkingSpaces[i] = new parkingSpace();
                    parkingSpaces[i].ID = "ID Space";
                    parkingSpaces[i].Icon = Resources.car;
                    parkingSpaces[i].IconBg = Color.LightGray;
                }                
                
                if (layoutPnl.Controls.Count < 0)
                    layoutPnl.Controls.Clear();
                else
                    layoutPnl.Controls.Add(parkingSpaces[i]);
            }
        }
    }
}
