using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4.Class_Oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Öğretmenler;");

            Person Teacher = new Person(); // tanımladığımız  class tan verileri almak için nesne yaptık
            Teacher.name = "Ali";    // name özelliğine isim tanımladık öğretmenler için
            Teacher.surname = "Kaplan ";  // surname özelliğine isim tanımladık öğretmenler için
            Teacher.age = "18.10.1987";    // age özelliğine isim tanımladık öğretmenler için
            Console.WriteLine($"İsim: {Teacher.name}  \r\nSoy isim: {Teacher.Surname} \r\nDoğum Tarihi: {Teacher.age}"); // ekrana yazdırdık
            Person Teacher1 = new Person(); // tanımladığımız  class tan verileri almak için nesne yaptık
            Teacher1.name = "Haydar ";   // name özelliğine isim tanımladık öğretmenler için
            Teacher1.surname = "Kara";   // surname özelliğine isim tanımladık öğretmenler için
            Teacher1.age = "12.07.1985";   // age özelliğine isim tanımladık öğretmenler için
            Console.WriteLine($"İsim:  {Teacher1.name}  \r\nSoy isim: {Teacher1.Surname} \r\nDoğum Tarihi: {Teacher1.age}"); // ekrana yazdırdık
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Öğrenciler ;");
            Person Student = new Person();  // tanımladığımız  class tan verileri almak için nesne yaptık
            Student.name = "Polat";      // name özelliğine isim tanımladık öğrenciler için
            Student.surname = "Alemdar";   // surname özelliğine isim tanımladık öğrenciler için
            Student.age = "12.12.2008";     // age özelliğine  isim tanımladık öğrenciler için
            Console.WriteLine($"İsim: {Student.name}  \r\nSoy isim: {Student.Surname} \r\nDoğum Tarihi: {Student.age}");  // ekrana yazdırdık

            Person Student1 = new Person();   // tanımladığımız  class tan verileri almak için nesne yaptık
            Student1.name = "Memati";      // name özelliğine isim tanımladık öğrenciler için
            Student1.surname = "Baş";         // surname özelliğine isim tanımladık öğrenciler için
            Student1.age = "01.09.2009";      // age özelliğine  isim tanımladık öğrenciler için
            Console.WriteLine($"İsim: {Student1.name}  \r\nSoy isim: {Student1.Surname} \r\nDoğum Tarihi: {Student1.age}");  // ekrana yazdırdık
            Console.ReadKey();
        }
    }
}
