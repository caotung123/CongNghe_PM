using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    public class NuocUong
    {
        private byte[] hinhanh;
        private string manuoc;
        private string tennuoc;
        private string dvt;
        private int dongia;
        private int tonkho;
        private string maloai;

        public NuocUong()
        {
        }

        public NuocUong(byte[] hinhanh, string manuoc, string tennuoc, string dvt, int dongia, int tonkho, string maloai)
        {
            this.hinhanh = hinhanh;
            this.manuoc = manuoc;
            this.tennuoc = tennuoc;
            this.dvt = dvt;
            this.dongia = dongia;
            this.tonkho = tonkho;
            this.maloai = maloai;
        }

        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Manuoc { get => manuoc; set => manuoc = value; }
        public string Tennuoc { get => tennuoc; set => tennuoc = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public int Tonkho { get => tonkho; set => tonkho = value; }
        public string Maloai { get => maloai; set => maloai = value; }
    }
}
