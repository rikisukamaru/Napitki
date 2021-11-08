using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum Type { Вино, Водка, Шампанское, Коньяк, Виски };
    public enum Numb : Int32 {_023334121,_324167254,_47898222,_58732425,_4662341334,_6523457};
    class Alco : Napitki
    {
       private  double percent;
       public Type tip = Type.Вино;
        public Numb kod = Numb._324167254;
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
            str += String.Format("\nАкциз: {0}", this.kod);
            
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
                tip = (Type)rnd.Next(4),
                kod = (Numb)rnd.Next(6)

            };

        }
    }
}
