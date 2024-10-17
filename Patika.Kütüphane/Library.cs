using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Kütüphane
{
    public class Library
    {
        public string BookName;
        public string WriterName;
        public string WriterSurname;
        public int PageNumber;
        public string Publishinghouse;
        public DateTime Registrationdate = DateTime.Now;

        public Library()
        {
            BookName = "Adı Aylin";
            WriterName = "Ayşe";
            WriterSurname = "Kulin";
            PageNumber = 320;
            Publishinghouse = "Remzi Kitapevi";
            Registrationdate = DateTime.Now;

        }
        public Library(string bookName, string writerName, string writerSurname, int pageNumber, string publishinghouse, DateTime registrationdate)
        {
            BookName = bookName;
            WriterName = writerName;
            WriterSurname = writerSurname;
            PageNumber = pageNumber;
            Publishinghouse = publishinghouse;
            Registrationdate = registrationdate;
        }
    }
}
