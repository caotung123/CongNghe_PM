using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class KhachHang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string sdt;
        private int diemtl;
        private string mathe;

        public KhachHang()
        {
        }

        public KhachHang(string makh, string tenkh, string diachi, string sdt, int diemtl, string mathe)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.diemtl = diemtl;
            this.mathe = mathe;
        }

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Diemtl { get => diemtl; set => diemtl = value; }
        public string Mathe { get => mathe; set => mathe = value; }
    }
}
