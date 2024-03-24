namespace CSProjeDemo2
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public double SaatlikUcret { get; set; }
        public double CalismaSaati { get; set; }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            return $"Personel Adı: {Ad}, Unvanı: {Unvan}, Çalışma Saati: {CalismaSaati}, Maaşı: {MaasHesapla()}";
        }
    }
}