using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Yonetici : Personel
    {
        public override double MaasHesapla()
        {
            double maas = SaatlikUcret * CalismaSaati;
            if (SaatlikUcret < 500)
                SaatlikUcret = 500;
            maas += BonusHesapla();
            return maas;
        }

        public double BonusHesapla()
        {
           
            return 1000; // Örnek bonus miktarı
        }
    }
}
