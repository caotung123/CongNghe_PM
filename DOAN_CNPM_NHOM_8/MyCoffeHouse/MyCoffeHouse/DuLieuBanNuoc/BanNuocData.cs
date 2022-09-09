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
    public class BanNuocData
    {
        //static SqlConnection sqlcon;

        public static List<BanNuoc> LayBanNuoc()
        {
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = "Select BANNUOC.MABAN, BANNUOC.TENBAN, BANNUOC.STATUS From BANNUOC";
            
            DataTable dt = Connection.LayDataTable(sql, sqlcon);
            if (dt.Rows.Count == 0)
                return null;

            List<BanNuoc> lstBanNuoc = new List<BanNuoc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanNuoc banNuoc = new BanNuoc();

                banNuoc.Maban = int.Parse(dt.Rows[i]["MABAN"].ToString());
                banNuoc.Tenban = dt.Rows[i]["TENBAN"].ToString();
                banNuoc.Status = dt.Rows[i]["STATUS"].ToString();

                lstBanNuoc.Add(banNuoc);
            }
            sqlcon.Close();
            return lstBanNuoc;
        }

        // sửa trạng thái bàn nước thành trạng thái có người
        public static bool SuaTrangThaiBanNuoc(int maban)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = string.Format("Update BANNUOC Set STATUS = N'Có Người' Where MABAN = {0}", maban);
            
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

        // sửa thành trạng thái thành trống
        public static bool SuaTrangThaiBanNuoc2(int maban)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = string.Format("Update BANNUOC Set STATUS = N'Trống' Where MABAN = {0}", maban);

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

        // thêm bàn ăn 
        public static bool addBanNuoc(BanNuoc banNuoc)
        {
            // chuỗi truy vấn thêm 1 món ăn vào bảng Món Nuoc
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = string.Format("insert into BAN(TENBAN,STATUS) values(N'{0}',N'{1}')", banNuoc.Tenban, banNuoc.Status);

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
        // xóa bàn ăn
        public static bool deleteBanNuoc(BanNuoc banNuoc)
        {
            // chuỗi truy vấn thêm xóa 1 hàng trong bảng ban
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = string.Format("Delete from BANNUOC Where MABAN = {0}", banNuoc.Maban);
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
        // sửa bàn ăn
        public static bool updateBanNuoc(BanNuoc banNuoc)
        {
            // chuỗi truy vấn sửa bàn ăn
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = string.Format("Update BANNUOC Set TENBAN = N'{0}' Where MABAN = {1}", banNuoc.Tenban, banNuoc.Maban);

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
        // tìm bàn ăn 
        public static List<BanNuoc> TimBanNuoc(string tenban)
        {
            string sql = "Select BANNUOC.MABAN, BANNUOC.TENBAN, BANNUOC.STATUS From BANNUOC where TENBAN like N'%" + tenban + "%'";
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            DataTable dt = Connection.LayDataTable(sql, sqlcon);
            if (dt.Rows.Count == 0)
                return null;

            List<BanNuoc> lstBanNuoc = new List<BanNuoc>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanNuoc banNuoc = new BanNuoc();
                banNuoc.Maban = int.Parse(dt.Rows[i]["MABAN"].ToString());
                banNuoc.Tenban = dt.Rows[i]["TENBAN"].ToString();
                banNuoc.Status = dt.Rows[i]["STATUS"].ToString();

                lstBanNuoc.Add(banNuoc);
            }
            sqlcon.Close();
            return lstBanNuoc;
        }

        
    }
}
