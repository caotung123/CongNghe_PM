using MyCoffeHouse.SQL;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.DuLieuBanNuoc
{
    public class NuocUongData
    {
        //========================LẤY DỮ LIỆU ADD VÀO BÀN NƯỚC===========================
        public static List<NuocUong> LoadNuoc()
        {
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = "Select NUOCUONG.MANUOC, NUOCUONG.TENNUOC, NUOCUONG.DVT, NUOCUONG.DONGIA From NUOCUONG";

            DataTable dt = Connection.LayDataTable(sql, sqlcon);
            if (dt.Rows.Count == 0)
                return null;

            List<NuocUong> lstNuoc = new List<NuocUong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NuocUong nuocUong = new NuocUong();
                nuocUong.Manuoc = dt.Rows[i]["MaNuoc"].ToString();
                nuocUong.Tennuoc = dt.Rows[i]["TenNuoc"].ToString();
                nuocUong.Dvt = dt.Rows[i]["DVT"].ToString();
                nuocUong.Dongia = int.Parse(dt.Rows[i]["DONGIA"].ToString());

                lstNuoc.Add(nuocUong);
            }
            sqlcon.Close();
            return lstNuoc;
        }

        // ------------  lấy id của nước uống dựa vào tên --------------------------
        public static int layMaNuoc(string tennuoc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = string.Format("Select NUOCUONG.MANUOC from NUOCUONG where TENNUOC = N'{0}'", tennuoc);
            sqlcon.Open();

            DataTable dtManuoc = Connection.LayDataTable(sql, sqlcon);
            if (dtManuoc.Rows.Count == 0)
                return -1;

            string manuoc = dtManuoc.Rows[0]["MaNuoc"].ToString();
            sqlcon.Close();
            return 0;
        }

        // ---------------------- tìm món nước --------------------------
        public static List<NuocUong> TimNuoc(string tenNuoc)
        {
            SqlConnection sqlcon = Connection.getcon();
            string sql = "NUOCUONG.MANUOC, NUOCUONG.TENNUOC, NUOCUONG.DVT, NUOCUONG.DONGIA From NUOCUONG where TENNUOC like N'%" + tenNuoc + "%'";

            DataTable dt = Connection.LayDataTable(sql, sqlcon);
            if (dt.Rows.Count == 0)
                return null;

            List<NuocUong> lstNuoc = new List<NuocUong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NuocUong nuocUong = new NuocUong();
                nuocUong.Manuoc = dt.Rows[i]["MaNuoc"].ToString();
                nuocUong.Tennuoc = dt.Rows[i]["TenNuoc"].ToString();
                nuocUong.Dvt = dt.Rows[i]["DVT"].ToString();
                nuocUong.Dongia = int.Parse(dt.Rows[i]["DonGia"].ToString());

                lstNuoc.Add(nuocUong);
            }
            sqlcon.Close();
            return lstNuoc;
        }

        // ------------------------ thêm nước uống -----------------------
        public static bool addNuoc(NuocUong nuocUong)
        {
            // chuỗi truy vấn thêm 1 món nước vào bảng Nước Uống
            string sql = string.Format("insert into NUOCUONG(TENNUOC,DVT,DONGIA) values(N'{0}',N'{1}',{2})", nuocUong.Tennuoc, nuocUong.Dvt, nuocUong.Dongia);
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            try
            {
                Connection.ThucThiTruyVanNonQuery(sql, sqlcon);
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                sqlcon.Close();
                return false;
            }
        }

        //------------------------ sửa nước uống ---------------------------------
        public static bool updateNuoc(NuocUong nuocUong)
        {
            // chuỗi truy vấn sửa nước
            string sql = string.Format("Update NUOCUONG Set TENNUOC = N'{0}', DVT = N'{1}', DONGIA = {2} Where MANUOC = {3}", nuocUong.Tennuoc, nuocUong.Dvt, nuocUong.Dongia, nuocUong.Manuoc);
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            try
            {
                Connection.ThucThiTruyVanNonQuery(sql, sqlcon);
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                sqlcon.Close();
                return false;
            }
        }
        // --------------------------- xóa nước uống   --------------------------------
        public static bool deleteNuoc(NuocUong nuocUong)
        {
            // chuỗi truy vấn xóa 1 món nước
            string sql = string.Format("Delete from NUOCUONG Where MANUOC = {0}", nuocUong.Manuoc);
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            try
            {
                Connection.ThucThiTruyVanNonQuery(sql, sqlcon);
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                sqlcon.Close();
                return false;
            }
        }

        // ------------------------- xóa toàn bộ món ăn -------------------------------------
        public static bool XoaAllNuoc()
        {
            // chuỗi truy vấn xóa toàn bộ dữ liệu bảng nước uống
            string sql = string.Format("Delete NUOCUONG");
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            try
            {
                Connection.ThucThiTruyVanNonQuery(sql, sqlcon);
                sqlcon.Close();
                return true;
            }
            catch (Exception)
            {
                sqlcon.Close();
                return false;
            }
        }

        
    }
}
