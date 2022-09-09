using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class LoaiThe
    {
        private string mathe;
        private string tenthe;
        private string ghichu;

        public LoaiThe()
        {
        }

        public LoaiThe(string mathe, string tenthe, string ghichu)
        {
            this.mathe = mathe;
            this.tenthe = tenthe;
            this.ghichu = ghichu;
        }

        public string Mathe { get => mathe; set => mathe = value; }
        public string Tenthe { get => tenthe; set => tenthe = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
