using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{

    abstract class Napitki
    {
        public static Random rnd = new Random();
        public double obiem;

        protected Napitki()
        {
            obiem = 0.1;
        }

        protected Napitki(double x)
        {
            obiem = x;
        }

        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъем напитка: {0} л.", this.obiem);
            return str;
        }

     
       


     }

}
