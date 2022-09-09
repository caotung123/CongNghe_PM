using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    class CoSo
    {
        private string macs;
        private string tencs;
        private string diachi;

        public CoSo()
        {
        }

        public CoSo(string macs, string tencs, string diachi)
        {
            this.macs = macs;
            this.tencs = tencs;
            this.diachi = diachi;
        }

        public string Macs { get => macs; set => macs = value; }
        public string Tencs { get => tencs; set => tencs = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
