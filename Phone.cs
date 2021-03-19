using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Builder
{
    //product
    public class Phone
    {
        //temel özellikler
        public LensNumber lensNumber { get; set; }
        public ScreenType screenType { get; set; }
        public Size size { get; set; }
        public bool frontCamera { get; set; }
        public Color color { get; set; }

        //özellikler yazdırmak için
        public void PhoneContent()
        {
            Console.WriteLine("your phone is customize like :\n");
            Console.WriteLine("Lens Number: {0}", lensNumber);
            Console.WriteLine("Screen Type: {0}", screenType);
            Console.WriteLine("Size: {0}", size);
            Console.WriteLine("Color: {0}", color);
            if (frontCamera)
            {
                Console.WriteLine("Front camera exist");
            }

        }


    }

        public enum LensNumber
        {
            singleLens,
            dualLens,
            tripleLens
        }

        public enum ScreenType
        {
            LCD,
            OLED,
            AMOLED
        }
         public enum Size
        {
            small,
            medium,
            larg
        }

        public enum Color
        {
            Black=1,
            White=2,
            Grey=3
        }
    
}
