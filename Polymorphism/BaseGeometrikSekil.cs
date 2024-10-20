using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometrikSekil
    {
        double Yükseklik;
        double Genişlik;
        double Sonuç;
        public virtual void AlanHesapla()
        {
            double Sonuç = Yükseklik * Genişlik;
            Console.WriteLine("Karenin Alanı: " + Sonuç);
        }
    }
    public class Kare : BaseGeometrikSekil
    {

        public override void AlanHesapla()
        {
            double Yükseklik = 16;
            double Genişlik = 16;
            double Sonuç = Yükseklik * Genişlik;

            Console.WriteLine("Karenin Alanı: " + Sonuç);

        }
    }
    public class Dikdörtgen : BaseGeometrikSekil
    {

        public override void AlanHesapla()
        {
            double Yükseklik = 12;
            double Genişlik = 21;
            double Sonuç = Yükseklik * Genişlik;

            Console.WriteLine("Dikdörtgenin Alanı : " + Sonuç);
        }
    }
    public class Uçgen : BaseGeometrikSekil
    {
        public override void AlanHesapla()
        {
            double Yükseklik = 32;
            double Genişlik = 21;
            double Sonuç = (Yükseklik * Genişlik) / 2;

            Console.WriteLine("Üçgenin Alanı : " + Sonuç);

        }
    }
}




