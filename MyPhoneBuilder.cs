using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Builder
{
    public  class MyPhoneBuilder : PhoneBuilder
    {
        public override void ChooseColor()
        {
            //bu phone nesnesinin özelliklere değer altıyoruz
            phone.color = Color.Black;
        }

        public override void ChooseLens()
        {
            phone.lensNumber = LensNumber.singleLens;
        }
        

        public override void ChooseScreenType()
        {
            phone.screenType = ScreenType.LCD;
        }

        public override void ChooseSize()
        {
            phone.size = Size.medium;
        }

        public override void FrontCamera()
        {
            phone.frontCamera = true;
        }
    }
}
