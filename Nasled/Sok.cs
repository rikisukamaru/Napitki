using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    class Sok : Napitki
    {
        private string frukt;
        private bool myakoti;

        public Sok()
        {
            obiem = 0;
            frukt = "";
            myakoti = false;
        }

        public Sok(string fr, bool mya, double ob) : base()
        {
            obiem = ob;
            frukt = fr;
            myakoti = mya;
        }
        public override string getInfo()
        {
            var Sok = new List<Sok>();
            var sok1 = new Sok("Апельсин", true, 0.6);
            var sok2 = new Sok("Яблоко", false, 1);

            return "";
        }
    }
}