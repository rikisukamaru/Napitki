using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum gz {SoSaSoSa, FantaЗёр, БонАква, Кайфарик };
    class Gaz : Napitki
    {
        public gz nameGaz = gz.FantaЗёр;
        private int puzirkov;

        public Gaz() : base()
        {
            obiem = 0.1;
            nameGaz = gz.SoSaSoSa;
            puzirkov = 0;
        }
        public Gaz(double ob, gz ng,int puz) : base()
        {
            obiem = ob;
            nameGaz = ng;
            puzirkov = puz;
        }

        public override String GetInfo()
        {
           
            var str = "Раздел:\tГазировка";
            str += String.Format("\nМарка газировки: {0} ", this.nameGaz);
            str += base.GetInfo();
            str += String.Format("\nКол-во пузырьков: {0} ", this.puzirkov);
            return str;
        }
        public static Gaz Generator()
        {
            return new Gaz
            {
                obiem = 0.1 + rnd.Next() % (3.5),
                puzirkov = 1000 + rnd.Next() % 3500,
                nameGaz = (gz)rnd.Next(3)
            };

        }
    }
}
