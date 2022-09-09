using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class DangNhap
    {
        private string username;
        private string password;
        private string quyen;
        private string manv;

        public DangNhap()
        {
        }

        public DangNhap(string username, string password, string quyen, string manv)
        {
            this.username = username;
            this.password = password;
            this.quyen = quyen;
            this.manv = manv;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Manv { get => manv; set => manv = value; }
    }
}
