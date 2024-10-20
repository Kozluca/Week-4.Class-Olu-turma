using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BaseKisi baseKisi = new BaseKisi();
            baseKisi.Information("Ayşe","Sarı","Ahmet","Yıldız");

            Teacher teacher = new Teacher();
            teacher.teacher();
            Student student = new Student();
            student.student();
            Console.ReadKey();
        }
    }
}
