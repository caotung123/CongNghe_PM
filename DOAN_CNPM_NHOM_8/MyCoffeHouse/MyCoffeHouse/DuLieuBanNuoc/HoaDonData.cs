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
    public class HoaDonData
    {
        
        static SqlCommand sqlCommand; // Dùng để truy vấn và cập nhật vào csdl
        static SqlConnection sqlcon;

        // load hoa don
        public static List<HoaDon> LoadHoaDon(int maban)
        {
            string sql = "SELECT CTHD.MACTHD, NUOCUONG.TENNUOC, CTHD.SOLUONG, NUOCUONG.DONGIA, (CTHD.SOLUONG * NUOCUONG.DONGIA) as ThanhTien from BANNUOC, HOADON, NUOCUONG, CTHD " +
                "WHERE CTHD.MANUOC = NUOCUONG.MANUOC AND CTHD.MAHD = HOADON.MAHD AND HOADON.MABAN = BANNUOC.MABAN AND BANNUOC.MABAN = " + maban;
            sqlcon = Connection.getcon();
            sqlcon.Open();
            DataTable dtHoaDon = Connection.LayDataTable(sql, sqlcon);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<HoaDon> lstHoaDon = new List<HoaDon>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.Mahd = int.Parse(dtHoaDon.Rows[i]["MaHD"].ToString());
                hoaDon.Tennuoc = dtHoaDon.Rows[i]["TenNuoc"].ToString();
                hoaDon.Soluong = int.Parse(dtHoaDon.Rows[i]["SoLuong"].ToString());
                hoaDon.Gia = int.Parse(dtHoaDon.Rows[i]["Gia"].ToString());
                hoaDon.Thanhtien = int.Parse(dtHoaDon.Rows[i]["ThanhTien"].ToString());

                lstHoaDon.Add(hoaDon);
            }
            sqlcon.Close();
            return lstHoaDon;
        }

        //Lấy mã của hóa đơn
        public static int layIDHoaDon(int maban)
        {
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            string sql = "SELECT HOADON.MAHD FROM BAN, HOADON WHERE HOADON.MABAN" + maban;
            DataTable dtIDHD = Connection.LayDataTable(sql, sqlcon);
            if (dtIDHD.Rows.Count == 0)
                return -1;
            int mahd = int.Parse(dtIDHD.Rows[0]["MaHD"].ToString());
            sqlcon.Close();
            return mahd;
        }

        //Thêm hóa đơn
        public static bool ThemHoaDon(int maban)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string sql = string.Format("insert into HoaDon(Maban,Status) values({0},{1})", maban, 0);
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

        //Thêm thông tin hóa đơn
        public static bool ThemThongTinHD(int mahd, string manuoc, int soluong)
        {
            string sql = string.Format("INSERT INTO CTHD(MAHD,MANUOC,SOLUONG) VALUES({0}, {1}, {2})", mahd, manuoc, soluong);
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

        //Cập nhật số lượng nước
        public static bool CapNhatSoLuongNuoc(int mahd, int manuoc, int soluong)
        {
            string sql = string.Format("UPDATE CTHD SET SOLUONG = {0} WHERE MAHD = {1} AND MANUOC = {2}", mahd, manuoc, soluong);
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

        //Update số tiền cho hóa đơn
        public static bool UpdateHD(int maban, string ngaylap, int tinhtrang, int sotien)
        {
            
            string sql = string.Format("UPDATE HOADON SET STATUS = {0}, NGAYLAP = '{1}', SOTIEN = {2} WHERE MABAN = {3} AND TINHTRANG = 0", maban, ngaylap, tinhtrang, sotien);
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

        // lấy danh sách hóa đơn đã thanh toán
        public static List<QuanLyHD> DanhSachHoaDon()
        {
            string sql = "SELECT HOADON.MAHD, BANNUOC.TENBAN, HOADON.NGAYLAP, HOADON.SOTIEN from HOADON, BANNUOC WHERE HOADON.MABAN = BANNUOC.MABAN AND TINHTRANG = 'ĐÃ THANH TOÁN'";
            SqlConnection sqlcon = Connection.getcon();
            sqlcon.Open();
            DataTable dtHoaDon = Connection.LayDataTable(sql, sqlcon);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<QuanLyHD> danhSachHoaDon = new List<QuanLyHD>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLyHD hoaDon = new QuanLyHD();
                hoaDon.Mahd = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.Tenban = dtHoaDon.Rows[i]["TenBan"].ToString();
                hoaDon.Tinhtrangthanhtoan = "Đã thanh toán";
                hoaDon.Ngaythanhtoan = DateTime.Parse(dtHoaDon.Rows[i]["NgayThanhToan"].ToString());
                hoaDon.Sotien = int.Parse(dtHoaDon.Rows[i]["SoTien"].ToString());

                danhSachHoaDon.Add(hoaDon);
            }
            sqlcon.Close();
            return danhSachHoaDon;
        }


            //Xóa nước uống ra khỏi hóa đơn
        public static bool XoaNuocUong(int mahd, int manuoc)
        {
            string sql = string.Format("DELETE FROM CTHD WHERE CTHD.MAHD = {0} AND CTHD.MANUOC = {1}", mahd, manuoc);
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

        //Xóa hết thông tin hóa đơn của bàn
        public static bool XoaThongTinHD(int mahd)
        {
            string sql = string.Format("DELETE FROM CTHD WHERE CTHD.MAHD = {0}", mahd);
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

        //Xóa hóa đơn dựa vào mã bàn
        public static bool XoaHDDuaVaoMaBan(int maban)
        {
            string sql = string.Format("DELETE FROM HOADON WHERE HOADON.MABAN = {0}", maban);
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

        //Xóa hóa đơn
        public static bool XoaHD(int mahd)
        {
            string sql = string.Format("DELETE FROM HOADON WHERE HOADON.MAHD = {0}", mahd);
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
        //Xóa toàn bộ hóa đơn
        public static bool XoaAllHD()
        {
            string sql = string.Format("DELETE FROM HOADON");
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
