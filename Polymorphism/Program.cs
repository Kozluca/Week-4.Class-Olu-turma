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
          
            BaseGeometrikSekil baseGeometrikSekil = new Uçgen();
            baseGeometrikSekil.AlanHesapla();
            BaseGeometrikSekil baseGeometrik = new Kare();
            baseGeometrik.AlanHesapla();
            BaseGeometrikSekil baseGeometrikSekil1=new Dikdörtgen();
            baseGeometrikSekil1 .AlanHesapla();
           
             Console.ReadKey();

        }
    }
}
