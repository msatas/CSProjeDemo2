using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Memur : Personel
    {
        public int Derece { get; set; }

        public override double MaasHesapla()
        {
            double maas = 0;
            if (CalismaSaati <= 180)
                maas = SaatlikUcret * CalismaSaati;
            else
                maas = SaatlikUcret * 180 + (CalismaSaati - 180) * SaatlikUcret * 1.5;
            return maas;
        }
    }
}