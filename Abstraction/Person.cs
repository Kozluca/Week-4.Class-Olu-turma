using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    public abstract class Duty        // abstract sınıf tanımladık 
    {
        public abstract void Gorev(); // override etmek için metot tanımladık
    }

    public class Hasan : Duty  // Hasan adında sınıf oluşturduk ve Duty sınıfından miras aldık
    {
        public string Name { get; set; }      // Propertilerimizi tanımladık
        public string SurName { get; set; }
        public string Departman { get; set; }

        public Hasan(string name, string surName, string departman) // constuctor ile değerleri belirledik
        {
            Name = name;
            SurName = surName;
            Departman = departman;
        }

        public override void Gorev()               // override yaparak istediğimiz değişikliği yaptık

        {
            Console.WriteLine("İnsan Kaynakları Müdürü olarak çalısıyorum");
        }
    }
    public class Ali : Duty // Ali adında sınıf oluşturduk ve Duty sınıfından miras aldık
    {
        public string Name { get; set; }       // Propertilerimizi tanımladık
        public string SurName { get; set; }
        public string Departman { get; set; }

        public Ali(string name, string surName, string departman)   // constuctor ile değerleri belirledik
        {
            Name = name;
            SurName = surName;
            Departman = departman;
        }

        public override void Gorev()          // override yaparak istediğimiz değişikliği yaptık

        {
            Console.WriteLine("Tekniker olarak çalışıyorum");
        }
    }
    public class Fatma : Duty   // Fatma adında sınıf oluşturduk ve Duty sınıfından miras aldık
    {
        public string Name { get; set; }      // Propertilerimizi tanımladık
        public string SurName { get; set; }
        public string Departman { get; set; }

        public Fatma(string name, string surName, string departman)       // constuctor ile değerleri belirledik
        {
            Name = name;
            SurName = surName;
            Departman = departman;
        }

        public override void Gorev()            // override yaparak istediğimiz değişikliği yaptık

        {
            Console.WriteLine("Üretim Mügendisi olarak çalısıyorum.");
        }
    }






}


