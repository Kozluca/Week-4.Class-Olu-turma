using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Kütüphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(); // kütüphaneden nesne oluşturduk, parametresiz nesne oluşturduk
            Console.WriteLine("Yazarın adı: " + library.WriterName + "\r\nYazarın Soyadı: " + library.WriterSurname + "\r\nSayfa sayısı: " + library.PageNumber + "\r\nKitabın adı: " + library.BookName +
    "\r\nYayın evi: " + library.Publishinghouse + "\r\nKayıt Tarihi: " + DateTime.Now); // ekrana istediklerimizi yazdırdık, parametre kullanmadık.

            Console.WriteLine("------------------------------------------------");

            Library library1 = new Library("Adı Aylin", "Ayşe", "Kulin", 320, "Remzi Yayınevi", DateTime.Now); // beliirlediğimiz parametreler ile nesne oluşturduk. parametre değerlerini girdik
            // parametreleri class ın içinde oluşturduk
            Console.WriteLine("Kitap adı: " + library.BookName);
            Console.WriteLine("Yazarın Adı: " + library.WriterName);           // ekrana yazdırdık
            Console.WriteLine("Yazarın Soyadı: " + library.WriterSurname);
            Console.WriteLine("Sayfa Sayısı: " + library.PageNumber);
            Console.WriteLine("Yayın Evi: " + library.Publishinghouse);
            Console.WriteLine("Kayıt Tarihi: " + DateTime.Now);
            Console.WriteLine("------------------------------------------------");

            Library library2 = new Library("Hayaller", "Ahmet", "Yılmaz", 320, "Alfa Yayınları", DateTime.Now);
                        Console.WriteLine("Yazarın adı: " + library2.WriterName + "\r\nYazarın Soyadı: " + library2.WriterSurname + "\r\nSayfa sayısı: " + library2.PageNumber + "\r\nKitabın adı: " + library2.BookName +
               "\r\nYayın evi: " + library2.Publishinghouse + "\r\nKayıt Tarihi: " + DateTime.Now);
                        Console.WriteLine("------------------------------------------------");


            Library library3 = new Library("Gökyüzü", "Ayşe", "Karan", 215, "Beta Yayınları", DateTime.Now);
                        Console.WriteLine("Yazarın adı: " + library3.WriterName + "\r\nYazarın Soyadı: " + library3.WriterSurname + "\r\nSayfa sayısı: " + library3.PageNumber + "\r\nKitabın adı: " + library3.BookName +
                "\r\nYayın evi: " + library3.Publishinghouse + "\r\nKayıt Tarihi: " + DateTime.Now);
                        Console.WriteLine("------------------------------------------------");


            Library library4 = new Library("Hayat", "Mehmet", "Demir", 450, "Gama Yayınları", DateTime.Now);
                        Console.WriteLine("Yazarın adı: " + library4.WriterName + "\r\nYazarın Soyadı: " + library4.WriterSurname + "\r\nSayfa sayısı: " + library4.PageNumber + "\r\nKitabın adı: " + library4.BookName +
              "\r\nYayın evi: " + library4.Publishinghouse + "\r\nKayıt Tarihi: " + DateTime.Now);
            Console.ReadKey();
            // class : oluşturduğumuz class ile ktap bilgilerini ve veri tiplerini belirledik
            // property: class ın içindeki veriler property leri oluşturuyor : string BookName gibi
            // new : new komutu ile oluşturduğumuz class tan nesne üretiyoruz ve bu nesneyi kullanıyoruz
            // constratuctor : class ın default yada parametre alan farklı türlerinin yapısıdır
        }
    }
}
