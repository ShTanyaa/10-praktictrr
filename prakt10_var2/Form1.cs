using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt10_var2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Car
        {
            public string name;
            private double cost=100000.0;
            public int power;
            private string data = "14 октября 2010 год";

            public void SetYear(int year)
            {
                if (year > 2017)
                {
                    cost = cost + (cost * 0.1);
                }
            }
            public double Getyear()
            {
                return cost;
            }
            public string SetData()
            {
                return data;
            }

            public Car(string name, double cost, int power)
            {
                this.name = name;
                this.cost = cost;
                this.power = power;
            }
            public Car()
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car1 = new Car();
            car1.power = (int)numericUpDown1.Value;
            car1.name = textBox1.Text;
            MessageBox.Show(String.Format("автомобиль\nназвание {0}\nмощность {1}\nстоимость {2}", car1.name, car1.power, car1.Getyear()), "автомобиль");
            car1.SetYear(2010);
            MessageBox.Show(String.Format("автомобиль\nназвание {0}\nмощность {1}\nстоимость {2}\nдата покупки {3}", car1.name, car1.power, car1.Getyear(),car1.SetData()), "автомобиль");
            car1.SetYear(2020);
            MessageBox.Show(String.Format("автомобиль\nназвание {0}\nмощность {1}\nстоимость{2}", car1.name, car1.power, car1.Getyear()), "автомобиль");
        }
    }
}
