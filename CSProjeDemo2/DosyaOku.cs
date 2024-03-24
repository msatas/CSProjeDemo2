using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace CSProjeDemo2
{
    public static class DosyaOku
    {
        public static List<Personel> PersonelListesiOlustur(string dosyaYolu)
        {
            List<Personel> personeller = new List<Personel>();

            string json = File.ReadAllText(dosyaYolu);
            dynamic data = JsonConvert.DeserializeObject(json);

            foreach (var item in data)
            {
                if (item.title == "Yonetici")
                {
                    Yonetici yonetici = new Yonetici();
                    yonetici.Ad = item.name;
                    yonetici.Unvan = item.title;
                    yonetici.SaatlikUcret = 500;
                    personeller.Add(yonetici);
                }
                else if (item.title == "Memur")
                {
                    Memur memur = new Memur();
                    memur.Ad = item.name;
                    memur.Unvan = item.title;
                    memur.SaatlikUcret = 500; 
                    personeller.Add(memur);
                }
            }

            return personeller;
        }
    }
}
