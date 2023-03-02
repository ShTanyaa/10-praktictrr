using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Books
    {
        public string name;
        public string avtor;
        public string count_pages;
        public int price;
        public int GetPrice()
        {
            return price;
        }
        public void SetPrice(int value)
        {
            price = value;
        }
        public void Info()
        {
            Console.WriteLine($"название {name}");
            Console.WriteLine($"автор {avtor}");
            Console.WriteLine($"кол-во стр {count_pages}");
            Console.WriteLine($"цена {price}");

        }
    }
}
