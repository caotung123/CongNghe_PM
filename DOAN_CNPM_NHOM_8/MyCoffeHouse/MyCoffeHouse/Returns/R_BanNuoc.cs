using MyCoffeHouse.DuLieuBanNuoc;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.Returns
{
    public class R_BanNuoc
    {
        ////////////////////////////////////////////////////////////////////////////
        ///TRẢ VỀ CÁC THUỘC TÍNH ĐƯỢC KHAI BÁO
        ///
        //Lấy danh sách bàn
        public static List<BanNuoc> LoadBanNuoc()
        {
            return BanNuocData.LayBanNuoc();
        }

        //Lấy mục sửa danh sách bàn thành có người
        public static bool SuaTrangThaiThanhCoNguoi(int maban)
        {
            return BanNuocData.SuaTrangThaiBanNuoc(maban);
        }

        //Lấy mục sửa danh sách bàn thành còn trống
        public static bool SuaTrangThaiThanhBanTrong(int maban)
        {
            return BanNuocData.SuaTrangThaiBanNuoc2(maban);
        }

        //Lấy mục thêm bàn nước
        public bool addBan(BanNuoc ban)
        {
            return BanNuocData.addBanNuoc(ban);
        }

        //Lấy mục sửa bàn nước
        public bool updateBan(BanNuoc ban)
        {
            return BanNuocData.updateBanNuoc(ban);
        }

        //Lấy mục xóa bàn nước
        public bool deleteBan(BanNuoc ban)
        {
            return BanNuocData.deleteBanNuoc(ban);
        }

        //Lấy mục tìm bàn
        public static List<BanNuoc> TimBan(string tenban)
        {
            return BanNuocData.TimBanNuoc(tenban);
        }

        ///////////////////////////////////////////////
        ///
        public static int TableWidth = 80;
        public static int TableHeight = 80;
    }
}
