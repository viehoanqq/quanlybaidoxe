﻿
using System.Data;
using CarParkingManagementSystem.DBLayer;
using Microsoft.Data.SqlClient;

namespace CarParkingManagementSystem.BSLayer
{
	public class login
	{
		Connector db = new Connector();
		public login() { }
		public object loginCheck(string username, string password)
		{
			object dt;
			string sql = string.Format("select * from TaiKhoan where username = '{0}' and password = '{1}'", username, password);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count == 1)
			{
				dt = table.Rows[0]["vaiTro"];
			}
			else
			{
				dt = null;
			}
			return dt;
		}

		public object ID(string username, string password)
		{
			object dt;
			string sql = string.Format("select * from TaiKhoan where username = '{0}' and password = '{1}'", username, password);
			SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count == 1)
			{
				dt = table.Rows[0]["ID"];
			}
			else
			{
				dt = null;
			}
			return dt;
		}
	}
}
