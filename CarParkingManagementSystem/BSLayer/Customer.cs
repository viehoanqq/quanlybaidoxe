using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.DBLayer;

namespace CarParkingManagementSystem.BSLayer
{
    public class Customer
    {
        Connector db = new Connector();
        public Customer() { }

        public DataTable BaiDoXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select IDDoXe, IDNguoiDung from NoiDoXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
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
            string sql = string.Format("update NoiDoXe set trangthai = '{0}', IDNguoiDung = '{1}' where IDDoXe = '{2}'", trangthai, IDKH, IDDoXe);
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
    }
}
