using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    public class HoaDon
    {
        private int mahd;
        private string tennuoc;
        private int soluong;
        private int gia;
        private int thanhtien;

        public HoaDon()
        {
        }

        public HoaDon(int mahd, string tennuoc, int soluong, int gia, int thanhtien)
        {
            this.mahd = mahd;
            this.tennuoc = tennuoc;
            this.soluong = soluong;
            this.gia = gia;
            this.thanhtien = thanhtien;
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public string Tennuoc { get => tennuoc; set => tennuoc = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
