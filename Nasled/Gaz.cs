using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    class Gaz : Napitki
    {
        private string nameGaz;
        private int puzirkov;

        public Gaz() : base()
        {
            obiem = 0;
            nameGaz = "";
            puzirkov = 0;
        }
        public Gaz(double ob, string ng,int puz) : base()
        {
            obiem = ob;
            nameGaz = ng;
            puzirkov = puz;
        }

        public override String getInfo()
        {
           // var list = new List<Gaz>();
            var st = "Газировка\n";
            st += String.Format("Объем:\t{0}", this.obiem);

            return st;
        }
    }
}
