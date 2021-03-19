using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BuildPhoneY : PhoneBuilder
    {
        public override void ChooseColor()
        {
            phone.color = Color.White;
        }

        public override void ChooseLens()
        {
            phone.lensNumber = LensNumber.tripleLens;
        }

        public override void ChooseScreenType()
        {
            phone.screenType = ScreenType.AMOLED;
        }

        public override void ChooseSize()
        {
            phone.size = Size.larg;
        }

        public override void FrontCamera()
        {
            phone.frontCamera = true;
        }
    }
}
