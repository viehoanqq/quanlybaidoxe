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
        public DataTable GetNoiDoXeByID(string ID)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from NoiDoXe where IDDoXe = '" + ID + "'", db.GetConnection());
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
        public bool ThemNoiDoXe(string IDDoXe, string IDNguoiDung, string IDNhanVien, string trangthai, string sotien)
        {
            string sql = string.Format("insert into NoiDoXe(IDDoXe, IDNguoiDung, IDNhanVien, trangthai, sotien) values('{0}', '{1}', '{2}', '{3}', '{4}')", IDDoXe, IDNguoiDung, IDNhanVien, trangthai, sotien);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool SuaNoiDoXe(string IDDoXe, string IDNguoiDung, string IDNhanVien, string trangthai, string sotien)
        {
            string sql = string.Format("update NoiDoXe set IDNguoiDung = '{0}', IDNhanVien = '{1}', trangthai = '{2}', sotien = '{3}' where IDDoXe = '{4}'", IDNguoiDung, IDNhanVien, trangthai, sotien, IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
        public bool XoaNoiDoXe(string IDDoXe)
        {
            string sql = string.Format("delete from NoiDoXe where IDDoXe = '{0}'", IDDoXe);
            SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
            db.OpenConnection();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
