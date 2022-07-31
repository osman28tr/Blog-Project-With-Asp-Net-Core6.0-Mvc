using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        Context context = new Context();
        public int DuyuruSayisi()
        {
            return context.Announcements.Count();
        }

        public int GelenMesajSayisi()
        {
            return 0;
        }

        public int ToplamKullaniciSayisi()
        {
            return 0;
        }

        public int ToplamYetenekSayisi()
        {
            return context.Skills.Count();
        }
    }
}
