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
	public partial class FormDiscount : Form
	{
		private int selectedDiscountId = -1;
		public FormDiscount()
		{
			InitializeComponent();
			LoadDiscountData();
		}

		Manager discountDAO = new Manager();

		private void LoadDiscountData()
		{
			dtgListDiscount.DataSource = discountDAO.GetAllDiscount();
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			string keyword = txtFind.Text.Trim();
			dtgListDiscount.DataSource = discountDAO.FinDiscountWithID(keyword);
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			LoadDiscountData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			formDiscountDetail form = new formDiscountDetail(icallBackf: () =>
			{
				LoadDiscountData();
			});
			form.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (selectedDiscountId != -1)
			{
				formDiscountDetail form = new formDiscountDetail(selectedDiscountId.ToString(), () =>
				{
					LoadDiscountData();
				});
				form.ShowDialog();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một mã giảm giá để sửa.");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (selectedDiscountId != -1)
			{
				var confirm = MessageBox.Show("Bạn có chắc muốn xóa mã giảm giá này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (confirm == DialogResult.Yes)
				{
					if (discountDAO.DeleteDiscountByID(selectedDiscountId))
					{
						MessageBox.Show("Xóa thành công!");
						LoadDiscountData();
					}
					else
					{
						MessageBox.Show("Xóa thất bại!");
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một mã giảm giá để xóa.");
			}
		}

		private void dtgListDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // Đảm bảo không phải tiêu đề
			{
				DataGridViewRow row = dtgListDiscount.Rows[e.RowIndex];
				if (row.Cells["ID"].Value != null)
				{
					selectedDiscountId = Convert.ToInt32(row.Cells["ID"].Value);
					// Bạn có thể test bằng:
					Console.WriteLine("Selected Discount ID: " + selectedDiscountId);
				}
			}
		}
	}
}
