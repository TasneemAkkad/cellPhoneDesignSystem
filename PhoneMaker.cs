using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    //director sipaış veren yer
    public class PhoneMaker
    {
        private readonly PhoneBuilder builder;

        //phonebulider abstract sınıfından bir parametrer alan constructor 
        public PhoneMaker (PhoneBuilder builder)
        {
            this.builder = builder;
        }

        //verilen sipariş oluşturmak için 
        public void BuildPhone()
        {
            builder.CreateNewPhone();
            builder.ChooseSize();
            builder.ChooseColor();
            builder.ChooseLens();
            builder.ChooseScreenType();
            builder.FrontCamera();
        }

        public Phone GetPhone()
        {
            return builder.GetPhone();
        }
    }
}
