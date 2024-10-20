using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BaseGeometrikSekil  // BaseGeometrikSekil adında bir class açtık
    {
        public double Yükseklik;              // propertyleri tanımladık
        public double Genişlik;
        public double Sonuç;
        public double Sonuç1;

        public virtual void AlanHesapla()   // daha sonra değiştirmek için virtual metodu kullandık
        {
            Sonuç = Yükseklik * Genişlik;                  // Alan Hesabını tanımladık
            Sonuç1 = (Yükseklik * Genişlik) / 2;
        }
    }
    public class Kare : BaseGeometrikSekil
    {
        public Kare(double yükseklik, double genişlik)
        {
            Yükseklik = yükseklik;
            Genişlik = genişlik;
        }
        public override void AlanHesapla()   // override ile değişiklik yapabiliyoruz.
        {
            base.AlanHesapla();
            Console.WriteLine("Karenin Alanı: " +Sonuç);
        }
    }
    public class Dikdörtgen : BaseGeometrikSekil
    {
        public Dikdörtgen(double yükseklik, double genişlik)
        {
            Yükseklik = yükseklik;
            Genişlik = genişlik;
        }
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            Console.WriteLine("Dikdörtgenin Alanı: " + Sonuç);
        }
    }
    public class Ucgen : BaseGeometrikSekil
    {
        public Ucgen(double yükseklik, double genişlik)
        {
            Yükseklik = yükseklik;
            Genişlik = genişlik;
        }
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            Console.WriteLine("Ücgenin Alanı: " + Sonuç1);
        }
    }
}








