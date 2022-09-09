using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.ThuocTinh
{
    public class BanNuoc
    {
        private int maban;
        private string tenban;
        private string status;

        public BanNuoc()
        {
        }

        public BanNuoc(int maban, string tenban, string status)
        {
            this.maban = maban;
            this.tenban = tenban;
            this.status = status;
        }

        public int Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Status { get => status; set => status = value; }
    }
}
