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
            for (var i = 0; i < 20; ++i)
            {
                switch(rnd.Next() %3)
                {
                    case 0:
                        this.napitkiList.Add(Alco.Generator());
                        break;
                    case 1: 
                        this.napitkiList.Add(Sok.Generator());
                        break;
                    case 2: 
                        this.napitkiList.Add(Gaz.Generator());
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
                    richTextBox3.Text += "Алкоголь\n";
                   
                }
                else if(napitki is Sok)
                {
                    sokCount += 1;
                    richTextBox3.Text += "Сок\n";

                }
                else if (napitki is Gaz)
                {
                    gazCount += 1;
                    richTextBox3.Text += "Газировка\n";

                }
            }
            richTextBox1.Text += "Алкоголь\tСок\tГазировка";
            richTextBox1.Text += "\n";
            richTextBox1.Text += String.Format("{0}\t\t{1}\t\t{2}",alcoCount, sokCount, gazCount);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox3.Clear();
            if (this.napitkiList.Count == 0)
            {
                richTextBox2.Text = "Пусто UwU";
                return;
            }

            
            var napitki = this.napitkiList[0];
            this.napitkiList.RemoveAt(0);


            richTextBox2.Text = napitki.GetInfo();

            ShowInfo();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void условиеЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Придумать иерархию классов.\nДолжен быть 1 базовый класс, и 3 класса наследника.У базового класса должно быть, как минимум одно свойство передающиеся по наследству остальным, у каждого из классов наследников должно быть как минимум два уникальных свойства.\nРеализовать эмулятор торгового автомата по образу и подобию как описано тут\nЕсли вы обычно делаете желтые задачки, то в эмуляторе надо реализовать отображение состояния очереди(чтобы было видно какие объекты в каком порядке сейчас находятся в автомате)\nЕсли чувствуете склонность к красным, добавьте картинки для каждого типа объектов, которые будут видны при выводе очереди");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Тимур Рикимару\nВерсия: 0.1");
        }
    }
}
