using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BaseGeometrikSekil Kare = new Kare(15, 15);
            Kare.AlanHesapla();
            BaseGeometrikSekil Dikdörtgen = new Dikdörtgen(21, 18);
            Dikdörtgen.AlanHesapla();
            BaseGeometrikSekil Ucgen = new Ucgen(24, 12);
            Ucgen.AlanHesapla();
            Console.ReadKey();

        }
    }
}
