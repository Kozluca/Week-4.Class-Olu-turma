using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        public string Name;
        public String Surname;
        DateTime Borntime = DateTime.Now;

        public Bebek(string name, string surname, DateTime Borntime)
        {
            Name = name;
            Surname = surname;
            Borntime = DateTime.Now;

        }
        public Bebek()
        {
            Name = "AYŞE";
            Surname = "Güzel";
            Borntime= DateTime.Now;
        }

    }
}
