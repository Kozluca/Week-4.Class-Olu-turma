using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    // Bu Uygulamda BaseKişi adında bir sınıf oluşturuyoruz ve bu sınıftam miras alıyoruz.
    // Miras aldığımız BaseKisi sınıfının özelliklerini kullanıyoruz ve Miras alınan sınıflarda da ekstra özellikler kullanıyoruz.
    public class BaseKisi  
    {
        string Name;
        string Surname;
        public void Information(string Name0, string Surname0, string Name, string Surname)  //BaseKisi için Konsol ekranına ad ve soyad yazdıran bir metot.    
        {
            Console.WriteLine("Öğretmen Adı:" + Name0);
            Console.WriteLine("Öğretmen SoyAdı:" + Surname0);
            Console.WriteLine("Öğrenci Adı:" + Name);
            Console.WriteLine("Öğrenci SoyAdı:" + Surname);
            Console.WriteLine("------------------------");
        }

    }
    public class Student : BaseKisi  //BaseKisi'den miras alan Ogrenci sınıfı
    {

        public void student()  // Öğrenci numarasını ekledik
        {
            int Studentnumber = 254879;
            string Name = "Ahmet";
            string SurName = "Yıldız";
            Console.WriteLine(" Öğrencini Adı: " + Name + "\r\n Soyadı: " + SurName + "\r\n Öğrenci numarası:" + Studentnumber);
        }
    }
    public class Teacher : BaseKisi     //BaseKisi'den miras alan Ogretmen sınıfı
    {
        public void teacher()  // Öğretmen Maaşını ekledik.
        {
            string Name = "Ayşe";
            string Surname = "Sarı";
            int salary = 45000;
            Console.WriteLine(" Öğretmenin Adı: " + Name + "\r\n Soyadı: " + Surname + "\r\n Maaş:" + salary + " TL" + "\r\n ---------------------");
        }
    }

}
