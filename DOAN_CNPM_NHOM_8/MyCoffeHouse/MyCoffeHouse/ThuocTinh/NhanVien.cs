using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class NhanVien
    {
        private string manv;
        private string tennv;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string cmnd;
        private string sdt;
        private string chucvu;
        private string macs;

        public NhanVien()
        {
        }

        public NhanVien(string manv, string tennv, DateTime ngaysinh, string gioitinh, string diachi, string cmnd, string sdt, string chucvu, string macs)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.sdt = sdt;
            this.chucvu = chucvu;
            this.macs = macs;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Macs { get => macs; set => macs = value; }
    }
}
