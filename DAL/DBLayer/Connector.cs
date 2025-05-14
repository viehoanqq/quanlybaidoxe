using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CarParkingManagementSystem.DBLayer
{
	public class Connector
	{
        string connStr = @"Server=DESKTOP-HB6E9EM;Database=quanlybaixe;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection conn = null;

		public Connector()
		{
			conn = new SqlConnection(connStr);
		}

		public SqlConnection GetConnection()
		{
			return conn;
		}

		public void OpenConnection()
		{
			if (conn.State == ConnectionState.Closed)
				conn.Open();
		}

		public void CloseConnection()
		{
			if (conn.State == ConnectionState.Open)
				conn.Close();
		}
	}
}
