using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car      // car sınıfı tanımladık ve propertylerini yazdık
    {
        public string _Renk;
        public string _Model;
        public string _Marka;
        public int _KapıSayısı;

        public Car(string renk, string model, string marka, int kapısayısı)
        {
            _Renk = renk;
            _Model = model;
            _Marka = marka;
            _KapıSayısı = kapısayısı;
        }
        public string Renk
        {
            get { return _Renk; }
            set { _Renk = value; }
        }
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }
        public string Marka
        {
            get { return _Marka; }
            set { _Marka = value; }
        }
        public int Kapısayısı
        {
            get { return _KapıSayısı; }
            set { _KapıSayısı = value; }
        }

        public void Information()
        {
            Console.WriteLine("Arabanın Markası: " + _Marka);
            Console.WriteLine("Arabanın Modeli: " + _Model);
            Console.WriteLine("Arabanın Rengi: " + _Renk);
            if (_KapıSayısı != 2 && _KapıSayısı != 4)
            {
                _KapıSayısı = -1;
                Console.WriteLine(_KapıSayısı + " Hatalı kapı sayısı");

                Console.WriteLine("Yeni kapı sayısı: " + _KapıSayısı);
            }
            else

                Console.WriteLine("Arabanın Kapı Sayısı: " + _KapıSayısı);
            Console.WriteLine("----------------------");

        }
    }
}
