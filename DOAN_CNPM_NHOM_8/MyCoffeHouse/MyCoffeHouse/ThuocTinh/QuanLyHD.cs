using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    public class QuanLyHD
    {
        private int mahd;
        private string tenban;
        private string tinhtrangthanhtoan;
        private DateTime ngaythanhtoan;
        private int sotien;

        public QuanLyHD()
        {
        }

        public QuanLyHD(int mahd, string tenban, string tinhtrangthanhtoan, DateTime ngaythanhtoan, int sotien)
        {
            this.mahd = mahd;
            this.tenban = tenban;
            this.tinhtrangthanhtoan = tinhtrangthanhtoan;
            this.ngaythanhtoan = ngaythanhtoan;
            this.sotien = sotien;
        }

        public int Mahd { get => mahd; set => mahd = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Tinhtrangthanhtoan { get => tinhtrangthanhtoan; set => tinhtrangthanhtoan = value; }
        public DateTime Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public int Sotien { get => sotien; set => sotien = value; }
    }
}
