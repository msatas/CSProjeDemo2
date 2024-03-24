
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSProjeDemo2
{
    public static class MaasBordro
    {
        public static void BordroOlustur(List<Personel> personeller)
        {
            string ay = DateTime.Now.ToString("MMMM yyyy");
            foreach (var personel in personeller)
            {
                string dosyaAdi = $"{personel.Ad}_{ay}.json";
                double maas = personel.MaasHesapla();

                Dictionary<string, object> raporDict = new Dictionary<string, object>
                {
                    { "Maas Bordro", ay },
                    { "Personel Ismi", personel.Ad },
                    { "Calisma Saati", personel.CalismaSaati },
                    { "Ana Odeme", $"{maas:₺}" }
                };

                if (personel is Yonetici)
                {
                    raporDict.Add("Bonus", $"{((Yonetici)personel).BonusHesapla():₺}");
                }

                string rapor = JsonConvert.SerializeObject(raporDict);

                File.WriteAllText(dosyaAdi, rapor);
                Console.WriteLine($"Bordro oluşturuldu: {dosyaAdi}");
            }
        }

        public static void AzCalisanlariRaporla(List<Personel> personeller)
        {
            Console.WriteLine("Az çalışan personeller:");
            foreach (var personel in personeller)
            {
                if (personel.CalismaSaati < 150)
                {
                    Console.WriteLine(personel);
                }
            }
        }
    }
}





