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
using System.Runtime.CompilerServices;

namespace CarParkingManagementSystem
{
	public partial class formParkingLot : Form
	{
		Customer customer = new Customer();
		public string ID;
		public int flag;
		Manager manager = new Manager();

        public formParkingLot(string _id, int _flag)
		{
			InitializeComponent();
			ID = _id;
			flag = _flag;
            cbdiscount.DataSource = manager.GetAllDiscount();
            cbdiscount.DisplayMember = "tenMa";
            cbdiscount.ValueMember = "phanTramGiam";

        }

		private void formParkingLot_Load(object sender, EventArgs e)
		{
			parkingLot();
		}

		private void parkingLot(int discount = 1)
		{
			DataTable dt = new DataTable();
			dt = customer.BaiDoXeoto();
			int numOfSpace = int.Parse(customer.NumOfSpace().ToString());
			parkingSpace[] parkingSpaces = new parkingSpace[100];

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				parkingSpaces[i] = new parkingSpace(1);
				bool check = bool.Parse(dt.Rows[i]["isBooked"].ToString());
				if (dt.Rows[i]["IDNguoiDung"].ToString().Trim() == string.Empty)
				{
					parkingSpaces[i] = new parkingSpace(1);
					parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
					parkingSpaces[i].IconBg = Color.White;
					parkingSpaces[i].IDUser = ID;
					parkingSpaces[i].Flag = flag;
					parkingSpaces[i].IsBooked = check;
                    parkingSpaces[i].discount = discount;
                    parkingSpaces[i].setdata(check);
                }
				else
				{
					parkingSpaces[i] = new parkingSpace(1);
					parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
					parkingSpaces[i].Icon = Resources.car;
					parkingSpaces[i].IconBg = Color.LightGray;
					parkingSpaces[i].IDUser = ID;
					parkingSpaces[i].Flag = flag;
                    parkingSpaces[i].IsBooked = check;
                    parkingSpaces[i].discount = discount;
                    parkingSpaces[i].setdata(check);
                }

				if (layoutPnl.Controls.Count < 0)
					layoutPnl.Controls.Clear();
				else
					layoutPnl.Controls.Add(parkingSpaces[i]);
			}
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			layoutPnl.Controls.Clear();
			parkingLot();
		}

        private void cbdiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdiscount.SelectedValue != null)
            {
                if (decimal.TryParse(cbdiscount.SelectedValue.ToString(), out decimal discount))
                {
                    layoutPnl.Controls.Clear();
                    parkingLot((int)discount);
                }
            }
        }
    }
}
