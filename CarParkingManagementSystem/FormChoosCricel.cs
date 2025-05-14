using CarParkingManagementSystem.BSLayer;
using CarParkingManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagementSystem
{
	public partial class FormChoosCricel : Form
	{
		Customer customer = new Customer();
		Manager manager = new Manager();
		public string ID;
		public int flag;

		public FormChoosCricel(string _id, int _flag)
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

		private void parkingLot(int discont =1 )
		{
			DataTable dt = new DataTable();
			dt = customer.BaiDoXeMay();
			int numOfSpace = int.Parse(customer.NumOfSpace().ToString());
			parkingSpace[] parkingSpaces = new parkingSpace[100];

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				bool isbooked = bool.Parse(dt.Rows[i]["isBooked"].ToString());
				if (dt.Rows[i]["IDNguoiDung"].ToString().Trim() == string.Empty)
				{
					parkingSpaces[i] = new parkingSpace(2 , () =>
					{
						parkingLot(discont);

                    });
					parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
					parkingSpaces[i].IconBg = Color.White;
					parkingSpaces[i].IDUser = ID;
					parkingSpaces[i].Flag = flag;
                    parkingSpaces[i].discount = discont;
					parkingSpaces[i].IsBooked = isbooked;
					parkingSpaces[i].setdata(isbooked);
                }
				else
				{
					parkingSpaces[i] = new parkingSpace(2 , () =>
					{
						parkingLot(discont);
					});
					parkingSpaces[i].IDSpace = dt.Rows[i]["IDDoXe"].ToString().Trim();
					parkingSpaces[i].Icon = Resources.xemay;
					parkingSpaces[i].IconBg = Color.LightGray;
					parkingSpaces[i].IDUser = ID;
					parkingSpaces[i].Flag = flag;
                    parkingSpaces[i].discount = discont;
                    parkingSpaces[i].IsBooked = isbooked;
                    parkingSpaces[i].setdata(isbooked);
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
