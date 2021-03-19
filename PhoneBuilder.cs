using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class PhoneBuilder
    {
        //yeni phone nesnesi olusturmak için
        protected Phone phone;

        public void CreateNewPhone()
        {
            phone = new Phone();
        }
        //phone nesnesi döndürmek için
        public Phone GetPhone()
        {
            return phone;
        }

        //abstract seçim metotları
        public abstract void ChooseLens();
        public abstract void ChooseScreenType();
        public abstract void ChooseSize();
        public abstract void ChooseColor();
        public abstract void FrontCamera();
    }
}
