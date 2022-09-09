using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class LoaiNuoc
    {
        private string maloai;
        private string tenloai;

        public LoaiNuoc()
        {
        }

        public LoaiNuoc(string maloai, string tenloai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
        }

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
