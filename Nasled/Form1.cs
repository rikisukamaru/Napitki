using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasled
{
    public partial class Form1 : Form
    {
        List<Napitki> napitkiList = new List<Napitki>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.napitkiList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch(rnd.Next() %3)
                {
                    case 0:
                        this.napitkiList.Add(new Alco());
                        break;
                    case 1: 
                        this.napitkiList.Add(new Sok());
                        break;
                    case 2: 
                        this.napitkiList.Add(new Gaz());
                        break;
                        
                }
                
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            int sokCount = 0;
            int gazCount = 0;
            int alcoCount = 0;

            foreach(var napitki in this.napitkiList)
            {
                if(napitki is Alco)
                {
                    alcoCount+= 1;
                   
                }
                else if(napitki is Sok)
                {
                    sokCount += 1;

                }
                else if (napitki is Gaz)
                {
                    gazCount += 1;

                }
            }
            richTextBox1.Text += "Алког\tСок\tГазир";
            richTextBox1.Text += "\n";
            richTextBox1.Text += String.Format("{0}\t{1}\t{2}",sokCount,gazCount,alcoCount);
            
        }
    }
}
