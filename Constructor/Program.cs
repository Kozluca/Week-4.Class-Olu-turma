using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bebek bebek = new Bebek("Ayşe", "Güzel", DateTime.Now);    // Constructor da değerleri burda verdik
            Console.WriteLine("Ingaaaaaaa");
            Console.WriteLine("İsim: " + bebek.Name);
            Console.WriteLine("Soyisim: " + bebek.Surname);
            Console.WriteLine("Doğum Tarihi: " + DateTime.Now);
            Bebek bebek1 = new Bebek();                                   // değerleri class ın içinde belirledik
            Console.WriteLine("INGAAAAAAAAAAAAAAAAAAAAAA \r\n İsim: "+bebek1.Name+" \r\n Soy isim : "+bebek1.Surname+ "\r\nDoğum Tarihi "+DateTime.Now);
            Console.ReadKey();
            
        }
    }
}
