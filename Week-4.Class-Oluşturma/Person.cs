using System;

namespace Week_4.Class_Oluşturma
{
    public class Person  // person adında class tanımladık
    {

        public string name;    // name adında özellik tanımladık
        public string surname;  // surname adında özellik tanımladık
        public string age;      // age adında özellik tanımladık


        public string Name
        {
            get      // geri dödüreceğimiz değer için get komutunu kullandık
            {
                return name;  // geri dödürmek istediğimiz değeri tanımladık
            }

            set      // belirledğimiz değeri name'e aktarmak için set komutunu kullandık
            {
                name = value;   // value komutuyla belirlediğimiz değeri name'e aktardık
            }

        }
        public string Surname
        {
            get      // geri dödüreceğimiz değer için get komutunu kullandık
            {
                return surname;  // geri dödürmek istediğimiz değeri tanımladık
            }
            set      // belirledğimiz değeri surname'e aktarmak için set komutunu kullandık
            {
                surname = value;   // value komutuyla belirlediğimiz değeri surname'e aktardık
            }
        }
        public string Age
        {
            get // geri dödüreceğimiz değer için get komutunu kullandık
            {
                return age;  // geri dödürmek istediğimiz değeri tanımladık
            }
            set  // belirledğimiz değeri age'e aktarmak için set komutunu kullandık
            {
                age = value; // value komutuyla belirlediğimiz değeri surname'e aktardık
            }
        }
    }


}



