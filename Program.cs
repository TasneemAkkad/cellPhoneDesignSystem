using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir tane phone talep ediyoruz
            var phoneMaker = new PhoneMaker(new MyPhoneBuilder());

            //o nesneyi oluşturyoruz
            phoneMaker.BuildPhone();

            //o phone bütün özelliklerle çağıryoruz
            var phoneX = phoneMaker.GetPhone();
            phoneX.PhoneContent();

            Console.WriteLine("\n\n");

            phoneMaker = new PhoneMaker(new BuildPhoneY());
            phoneMaker.BuildPhone();

            var phoneY = phoneMaker.GetPhone();
            phoneY.PhoneContent();



            Console.ReadKey();
        }
    }
}
