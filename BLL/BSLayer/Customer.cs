﻿
using System.Data;
using CarParkingManagementSystem.DBLayer;
using Microsoft.Data.SqlClient;

namespace CarParkingManagementSystem.BSLayer
{
	public class Customer
	{
		Connector db = new Connector();
		public Customer() { }

		public DataTable BaiDoXeoto()
		{
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("SELECT IDDoXe, IDNguoiDung , isBooked FROM NoiDoXe WHERE type LIKE '%oto%'", db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			return dt;
		}

		public DataTable BaiDoXeMay()
		{
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("SELECT IDDoXe, IDNguoiDung , isBooked FROM NoiDoXe WHERE type LIKE '%xe máy%'", db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			return dt;
		}

		public DataTable User(string ID)
		{
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select ID, ten, tuoi, diachi, sdt from ThongTinCaNhan where ID = '" + ID + "'", db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			return dt;
		}

		public DataTable user_pass(string ID)
		{
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select username, password from TaiKhoan where ID = '" + ID + "'", db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			return dt;
		}

		public bool DoiMatKhau(string username, string password)
		{
			string sql = string.Format("update TaiKhoan set password = '{0}' where username = '{1}'", password, username);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			db.OpenConnection();
			int result = cmd.ExecuteNonQuery();
			return result > 0;
		}

		public bool SuaThongTinCaNhan(string ID, string ten, string tuoi, string sdt, string diachi)
		{
			string sql = string.Format("update ThongTinCaNhan set ten = '{0}', tuoi = '{1}', sdt = '{2}', diachi = '{3}' where ID = '{4}'", ten, tuoi, sdt, diachi, ID);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			db.OpenConnection();
			int result = cmd.ExecuteNonQuery();
			return result > 0;
		}

		public object NumOfSpace()
		{
			object dt;
			string sql = string.Format("select COUNT(*) as SoLuong from NoiDoXe");
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count == 1)
			{
				dt = table.Rows[0]["SoLuong"];
			}
			else
			{
				dt = null;
			}
			return dt;
		}

		public bool DoXe(string IDDoXe, string IDKH, string trangthai)
		{
			string sql = string.Format("update NoiDoXe set trangthai = '{0}', IDNguoiDung = '{1}' , isBooked = 0 where IDDoXe = '{2}'", trangthai, IDKH, IDDoXe);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			db.OpenConnection();
			int result = cmd.ExecuteNonQuery();
			return result > 0;
		}

		public bool LayXe(string IDDoXe)
		{
			string sql = string.Format("update NoiDoXe set IDNguoiDung = null, trangthai = 'trong' where IDDoXe = '{0}'", IDDoXe);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			db.OpenConnection();
			int result = cmd.ExecuteNonQuery();
			return result > 0;
		}

		public object ViTriDoXe(string ID)
		{
			object dt;
			string sql = string.Format("select IDDoxe from NoiDoXe where IDNguoiDung = '{0}'", ID);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count == 1)
			{
				dt = table.Rows[0]["IDDoxe"];
			}
			else
			{
				dt = null;
			}
			return dt;
		}


        public string ViTriDoXemew(string ID)
        {
            string sql = $"select IDDoXe from NoiDoXe where IDNguoiDung = {ID}";
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                return table.Rows[0]["IDDoxe"].ToString();
            }
            return null;
        }

        public object GetNameCustomer(string ID)
		{
			object dt;
			string sql = string.Format("select ten from ThongTinCaNhan where ID = '{0}'", ID);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count == 1)
			{
				dt = table.Rows[0]["ten"];
			}
			else
			{
				dt = null;
			}
			return dt;
		}

		public DataTable ThongtinDoxe(string IDKH)
		{
			DataTable dt = new DataTable();
			SqlCommand cmd = new SqlCommand("select ID, ten, tuoi, diachi, sdt, bienSo, ngayDoXe, ngayLayXe, DX.sotien from ThongTinCaNhan CN inner join NoiDoXe DX on CN.ID = DX.IDNguoiDung where CN.ID = '" + IDKH + "'", db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);
			return dt;
		}

        public void DatTruocChoNgoi(string idDoXe, string idNguoiDung)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NoiDoXe SET isBooked = 1, trangthai = 'dattruoc' WHERE IDDoXe = @idDoXe", conn);
                cmd.Parameters.AddWithValue("@idDoXe", idDoXe);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
