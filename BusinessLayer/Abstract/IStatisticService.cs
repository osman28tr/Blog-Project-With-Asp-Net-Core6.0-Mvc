using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        int GelenMesajSayisi();
        int DuyuruSayisi();
        int ToplamKullaniciSayisi();
        int ToplamYetenekSayisi();
    }
}
