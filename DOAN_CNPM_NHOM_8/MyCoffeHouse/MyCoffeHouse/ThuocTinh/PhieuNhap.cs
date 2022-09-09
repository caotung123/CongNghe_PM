using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class PhieuNhap
    {
        private string mapn;
        private string manv;
        private string mancc;
        private string macs;
        private DateTime ngaylap;
        private int tongtien;

        public PhieuNhap()
        {
        }

        public PhieuNhap(string mapn, string manv, string mancc, string macs, DateTime ngaylap, int tongtien)
        {
            this.mapn = mapn;
            this.manv = manv;
            this.mancc = mancc;
            this.macs = macs;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
        }

        public string Mapn { get => mapn; set => mapn = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Macs { get => macs; set => macs = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
    }
}
