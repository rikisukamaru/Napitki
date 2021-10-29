﻿using System;
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
        public override String getInfo()
        {
            
            var s = "Сок\n";
            s += String.Format("Объем:\t{0}", this.obiem);
            return s;
        }
    }
}