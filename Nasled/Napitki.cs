using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{

    abstract class Napitki
    {
        protected double obiem;

        protected Napitki()
        {
            obiem = 0;
        }

        protected Napitki(double x)
        {
            obiem = x;
        }

        public abstract string getInfo();


     }

}
