using MyCoffeHouse.DuLieuBanNuoc;
using MyCoffeHouse.ThuocTinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeHouse.Returns
{
    public class R_NuocUong
    {
        /////////////////////////////////////////////////////////////////
        ///RETURN///
        ///
        public static List<NuocUong> LoadNuocUong()
        {
            return NuocUongData.LoadNuoc();
        }

        public static int layMaNuocUong(string tennuoc)
        {
            return NuocUongData.layMaNuoc(tennuoc);
        }

        public static List<NuocUong> TimNuocUong(string tennuoc)
        {
            return NuocUongData.TimNuoc(tennuoc);
        }

        public static bool addNuocUong(NuocUong nuocUong)
        {
            return NuocUongData.addNuoc(nuocUong);
        }

        public static bool updateNuocUong(NuocUong nuocUong)
        {
            return NuocUongData.updateNuoc(nuocUong);
        }

        public static bool deleteNuocUong(NuocUong nuocUong)
        {
            return NuocUongData.deleteNuoc(nuocUong);
        }

        public static bool XoaAllNuocUong()
        {
            return NuocUongData.XoaAllNuoc();
        }
    }
}
