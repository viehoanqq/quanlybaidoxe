using CarParkingManagementSystem.BSLayer;
using CarParkingManagementSystem.DBLayer;
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
	public partial class formDiscountDetail : Form
	{
		Manager manager = new Manager();
		string discountid;

		public bool Typeform;
		IcallBack.IcallBackf _icallbackf = null;
		public formDiscountDetail(IcallBack.IcallBackf icallBackf = null)
		{
			InitializeComponent();
			LoadData();
			Typeform = false;
			_icallbackf = icallBackf;
		}
		public formDiscountDetail(string id, IcallBack.IcallBackf icallBackf = null)
		{
			InitializeComponent();
			LoadData(id);
			Typeform = true;
			_icallbackf = icallBackf;
		}

		public void LoadData()
		{
			this.txttenMa.Clear();
			this.txtphanTramGiam.Clear();
			this.txtngayBatDau.Clear();
			this.txtngayKetThuc.Clear();
			this.txttenMa.Focus();
		}

		public void LoadData(string id)
		{
			DataTable dt = manager.GetDisCountWithID(id);
			this.txttenMa.Text = dt.Rows[0]["tenMa"].ToString();
			this.txtphanTramGiam.Text = dt.Rows[0]["phanTramGiam"].ToString();
			this.txtngayBatDau.Text = dt.Rows[0]["ngayBatDau"].ToString();
			this.txtngayKetThuc.Text = dt.Rows[0]["ngayKetThuc"].ToString();
			discountid = dt.Rows[0]["ID"].ToString();
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string tenMa = txttenMa.Text.Trim();
				decimal phanTramGiam = decimal.Parse(txtphanTramGiam.Text.Trim());
				DateTime ngayBatDau = DateTime.Parse(txtngayBatDau.Text.Trim());
				DateTime ngayKetThuc = DateTime.Parse(txtngayKetThuc.Text.Trim());

				bool result = false;

				if (Typeform)
				{
					// Sửa thông tin discount
					result = manager.UpdateDiscount(int.Parse(discountid), tenMa, phanTramGiam, ngayBatDau, ngayKetThuc);
					MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					// Thêm mới discount
					result = manager.AddDiscount(tenMa, phanTramGiam, ngayBatDau, ngayKetThuc);
					MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				if (result)
				{
					this.Close(); // Đóng form sau khi lưu thành công
				}
				else
				{
					MessageBox.Show("Thao tác không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			_icallbackf?.Invoke();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			_icallbackf?.Invoke();
			this.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			_icallbackf?.Invoke();
			this.Close();
		}
	}
}
