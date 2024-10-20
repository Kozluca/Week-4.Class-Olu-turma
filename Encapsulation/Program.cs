using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        // Bu Uygulamada bir Car classı oluşturduk ve property lerini tanımladık
        // Car classından bir nesne oluşturduk kapı sayısı için 2 ve 4 haricinde bir sayı girilirse hata mesajı yayınladık ve kapı sayısını 1 düşrdük.


        static void Main(string[] args)
        {
            Car car = new Car("Kırmızı", "Mustang", "Ford", 4);
            car.Information();
            Car car1 = new Car("Siyah ", "5.20", "BMW", 5);
            car1.Information();
            Console.ReadKey();

        }
    }
}
