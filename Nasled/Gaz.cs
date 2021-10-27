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

        public override string getInfo()
        {
            var list = new List<Gaz>();
            var gaz1 = new Gaz(1, "CocaCoca", 1500);
            var gaz2 = new Gaz(0.5, "Fanta", 1300);
        }
    }
}
