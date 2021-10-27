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
        public Alco(double q, double w, string s) : base()
        {
            percent = q;
            obiem = w;
            tip = s;
        }

        public override string getInfo() 
        {
            var list = new List<Alco>();
            var alco1 = new Alco(40.8,0.5,"Водка");
            var alco2 = new Alco(15, 0.7, "Вино");

        }
    }
}
