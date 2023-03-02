using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Worker
        {
            public string name;
            public int vozr;
            private double ves = 60.0;
            public void SetEat(double eda)
            {
                if(eda>10)
                {
                    ves = ves + (eda / 2);
                }
                ves += eda;
            }
            public double GetEat()
            {
                return ves;
            }
            public Worker(string name,int vozr,int ves)
            {
                this.name = name;
                this.vozr = vozr;
                this.ves = ves;
            }
            public Worker()
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker1 = new Worker();
            worker1.vozr = (int)numericUpDown1.Value;
            worker1.name = textBox1.Text;
            MessageBox.Show(String.Format("рабочий\nИмя {0}\nВозраст {1}\nВес {2}", worker1.name, worker1.vozr, worker1.GetEat()),"рабочий");
            worker1.SetEat(5);
            MessageBox.Show(String.Format("рабочий\nИмя {0}\nВозраст {1}\nВес {2}", worker1.name, worker1.vozr, worker1.GetEat()), "рабочий");
            worker1.SetEat(17);
            MessageBox.Show(String.Format("рабочий\nИмя {0}\nВозраст {1}\nВес {2}", worker1.name, worker1.vozr, worker1.GetEat()), "рабочий");
        }
    }
}
