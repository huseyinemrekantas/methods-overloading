using System;

namespace methods_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarili");
                Console.WriteLine(outSayi);
            }else
            {
                Console.WriteLine("Başarisiz");
            }

            Methods methods = new Methods();
            methods.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metot Aşırı Yükleme - Overloading
            int ifade = 999;
            methods.EkranaYazdir(Convert.ToString(ifade));
            methods.EkranaYazdir(ifade);
            methods.EkranaYazdir("H.Emre ","Kantas");
            //Hangi overload edilmiş metodun kullanılacağına Metot imzasına göre karar verir
            //metotAdı + parametre sayısı + parametre 'ye bakılır.
        }
    }
    class Methods
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
