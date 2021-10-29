using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    class Alco : Napitki
    {
       private  double percent;
        private string tip;
       public Alco()
        {
            percent = 0;
            obiem = 0;
            tip = "";
        }
        public Alco(double q,double w, string s) : base()
        {
            percent = q;
            obiem = w;
            tip = s;
        }

        public override String getInfo() 
        {
            var str = "Водка\n";
            str += String.Format("Объем:\t{0}",this.obiem);
          
            return str;
        }
    }
}
