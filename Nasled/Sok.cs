using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum Frukt { Яблоко, Мультифрукт, Апельсин, Вишня};
    class Sok : Napitki
    {
        public Frukt frukt = Frukt.Апельсин;
        private bool myakoti;

        public Sok()
        {
            obiem = 0.1;
            frukt = Frukt.Мультифрукт;
            myakoti = false;
        }

        public Sok(Frukt fr, bool mya, double ob) : base()
        {
            obiem = ob;
            frukt = fr;
            myakoti = mya;
        }
        public override String GetInfo()
        {

            var str = "Раздел:\tСок";

            str += base.GetInfo();
            str += String.Format("\nИспользуемый фрукт: {0} ", this.frukt);
            str += String.Format("\nНаличие мякоти: {0} ", this.myakoti);
            return str;
        }
        public static Sok Generator()
        {
            return new Sok
            {
                obiem = 0.1 + rnd.Next() % (3.5),
                myakoti = rnd.Next(2) == 0,
                frukt = (Frukt)rnd.Next(3)
            };

        }
    }

}