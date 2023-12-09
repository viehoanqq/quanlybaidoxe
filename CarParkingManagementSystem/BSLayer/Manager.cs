using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.DBLayer;

namespace CarParkingManagementSystem.BSLayer
{
    public class Manager
    {
        Connector db = new Connector();
        public Manager() { }
        public DataTable GetNoiDoXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public object GetTraNoiDoXe()
        {
            object dt;
            //SELECT COUNT(*) AS SoLuong FROM NoiDoXe WHERE trangthai<> 'trong'
            string sql = string.Format("SELECT COUNT(*) AS SoLuong FROM NoiDoXe WHERE trangthai = 'tra'");
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
        public object SoTienDaTra()
        {
            object dt;
            //SELECT SUM(CAST(sotien AS INT)) AS TongSoTienDaTra FROM NoiDoXe WHERE trangthai = 'trong'
            string sql = string.Format("SELECT SUM(CAST(sotien AS INT)) AS SoTien FROM NoiDoXe WHERE trangthai = 'tra'");
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                dt = table.Rows[0]["SoTien"];
            }
            else
            {
                dt = null;
            }
            return dt;
        }
        public DataTable TimKiemNoiDoXe(string keyword)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe where IDDoXe like '%" + keyword + "%' or  IDNguoiDung like '%" + keyword + "%' or trangthai like '%" + keyword + "%' or sotien like '%" + keyword + "%'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
