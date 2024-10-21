using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Hakan = new Person("Hakan", "Yıldız", "Üretim Mühendisi");   // person sınıfından Hakan adında nesne ürettik
            Hakan.Gorev();
            Console.WriteLine("-----------------------------");

            Person Ayşe = new Person("Ayşe ", "Kaplan", "İnsan Kaynakları Müdürü");      // person sınıfından Ayşe adında nesne ürettik
            Ayşe.Gorev();
            Console.WriteLine("-----------------------------");

            Person Veli = new Person("Veli", "Yeşil", "Aşçı");       // person sınıfından Ali adında nesne ürettik
            Veli.Gorev();

            Console.WriteLine("--------------2.Yöntem---------------");

            Hasan Hasan = new Hasan("Hasan", "Yıldız", "İnsan kaynakları"); //Hasan sınıfından nesne oluştruduk
            Hasan.Gorev();     // abstract Duty sıfıdındaki metodu çalğırdık
            Console.WriteLine("-----------------------------");

            Fatma Fatma = new Fatma("Fatma", "Kaplan", "Üretim");
            Fatma.Gorev();
            Console.WriteLine("-----------------------------");

            Ali Ali = new Ali("Ali", "Yeşil", "Bakım");
            Ali.Gorev();

            Console.ReadKey();
        }
        // Bir Firmada Çalışan 3 kişi için ad, soyad, departman bilgilerini aldık
        // Çalışanların Görevleri farklı olduğu için , Gorev metodu ile bilgileri alınan kişilerin yaptığı işe konsola yazdırdık
    }
}
