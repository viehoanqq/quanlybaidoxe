﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;
using CarParkingManagementSystem.BSLayer;
using System.IO;

namespace CarParkingManagementSystem
{
    public partial class formStaff : Form
    {
        Manager manager = new Manager();
        public formStaff()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                this.dtgChitietCanhan.DataSource = manager.GetAllNhanVien();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Nhân viên. Lỗi rồi!!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu cột ID của dòng hiện tại
            int r = dtgChitietCanhan.CurrentCell.RowIndex;
            string id = dtgChitietCanhan.Rows[r].Cells[0].Value.ToString();
            formStaffDetail form = new formStaffDetail(id);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formStaffDetail form = new formStaffDetail();
            form.ShowDialog();
        }

        private void formStaff_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFind_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtFind.Text == "")
                {
                    LoadData();
                }
                else
                {
                    this.dtgChitietCanhan.DataSource = manager.TimKiemNhanVien(txtFind.Text);
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Nhân viên. Lỗi rồi!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy dữ liệu cột ID của dòng hiện tại
                int r = dtgChitietCanhan.CurrentCell.RowIndex;
                string id = dtgChitietCanhan.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    manager.XoaNhanVien(id);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa dữ liệu!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Constant.Parth + "NhanVien.txt");
                sw.WriteLine("                                                    Danh sách Nhân Viên                                                          ");
                sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");

                for (int i = 0; i < dtgChitietCanhan.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgChitietCanhan.Columns.Count; j++)
                    {
                        sw.Write(" " + dtgChitietCanhan.Rows[i].Cells[j].Value.ToString() + " " + "|");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                }
                sw.Close();

                MessageBox.Show("Đã in danh sách!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("In thất bại!\n" + ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
