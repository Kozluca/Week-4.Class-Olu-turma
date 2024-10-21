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
            Hasan Hasan =new Hasan ("Hasan","Yıldız","İnsan kaynakları"); //Hasan sınıfından nesne oluştruduk
            Hasan.Gorev();     // abstract Duty sıfıdındaki metodu çalğırdık
            Fatma Fatma = new Fatma("Fatma", "Kaplan", "Üretim");
            Fatma.Gorev();
            Ali Ali = new Ali("Ali", "Yeşil", "Bakım");
            Ali.Gorev();
            Console.ReadKey();
        }
        // Bir Firmada Çalışan 3 kişi için ad, soyad, departman bilgilerini aldık
        // Çalışanların Görevleri farklı olduğu için , Gorev metodu ile bilgileri alınan kişilerin yaptığı işe konsola yazdırdık
    }
}
