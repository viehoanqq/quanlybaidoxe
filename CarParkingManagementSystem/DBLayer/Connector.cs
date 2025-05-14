using Microsoft.Data.SqlClient;
using System.Data;

namespace CarParkingManagementSystem.DBLayer
{
	public class Connector
	{
        string connStr = "Data Source=DESKTOP-HB6E9EM;Initial Catalog=quanlybaixe;Integrated Security=True;Trust Server Certificate=True";
        //string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=testDoXe;Integrated Security=True";
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
