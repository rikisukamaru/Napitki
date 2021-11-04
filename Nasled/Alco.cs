using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum Type { Вино, Водка, Шампанское, Коньяк, Виски };
    class Alco : Napitki
    {
       private  double percent;
       public Type tip = Type.Вино;
       public Alco()
        {
            percent = 0;
            obiem = 0.1;
            tip = Type.Вино;
        }
        public Alco(double q,double w, string s) : base()
        {
            percent = q;
            obiem = w;
            tip = Type.Водка;
        }
       
        public override String GetInfo() 
        {
            var str = "Раздел:\tАлкоголь";
           
            str += String.Format("\nТип алкоголя: {0} ", this.tip);
            str += base.GetInfo();
            str += String.Format("\nПроцент крепости: {0} ",this.percent);
            
            return str;
        }
        public static Alco Generator() 
        {
          //  Type type = new Type();
          //  Alco a = new Alco();
            //a.tip = (Type)rnd.Next(4);


          //  if (a.tip == Type.Вино)
          //  {

          //  }
            return new Alco
            {
                obiem = 0.3 + rnd.Next() % (3.5), 
                percent = 5 + rnd.Next() % 40, 
                tip = (Type)rnd.Next(4)
            };

        }
    }
}
