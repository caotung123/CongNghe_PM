using MyCoffeHouse.DuLieuBanNuoc;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.Returns
{
    public class R_HoaDon
    {
        public static List<HoaDon> LoadHoaDon(int maban)
        {
            return HoaDonData.LoadHoaDon(maban);
        }

        public static bool themHD(int maban)
        {
            return HoaDonData.ThemHoaDon(maban);
        }
        public static bool themTTHD(int mahd, string manuoc, int soluong)
        {
            return HoaDonData.ThemThongTinHD(mahd, manuoc, soluong);
        }

        public static int getIDHoaDon(int maban)
        {
            return HoaDonData.layIDHoaDon(maban);
        }

        public static bool CapNhatSoLuongNU(int soLuong, int mahd, int manuoc)
        {
            return HoaDonData.CapNhatSoLuongNuoc(soLuong, mahd, manuoc);
        }

        public static bool XoaNU(int mahd, int manuoc)
        {
            return HoaDonData.XoaNuocUong(mahd, manuoc);
        }

        // xóa thông tin hóa đơn
        public static bool XoaTTHD(int mahd)
        {
            return HoaDonData.XoaThongTinHD(mahd);
        }

        // xóa hóa đơn
        public static bool XoaHoaDon(int mahd)
        {
            return HoaDonData.XoaHD(mahd);
        }

        // update tiền cho hóa đơn
        public static bool UpdateHoaDon(int maban, string ngaylap, int tinhtrang, int sotien)
        {
            return HoaDonData.UpdateHD(maban, ngaylap, tinhtrang, sotien);
        }

        // lấy hóa đơn
        public static List<QuanLyHD> DSHD()
        {
            return HoaDonData.DanhSachHoaDon();
        }

        // xóa toàn bộ hóa đơn
        public static bool XoaToanBoHD()
        {
            return HoaDonData.XoaAllHD();
        }

        // Xóa hóa đơn dựa vào ID bàn
        public static bool XoaHoaDonCoMaban(int maban)
        {
            return HoaDonData.XoaHDDuaVaoMaBan(maban);
        }
    }
}
