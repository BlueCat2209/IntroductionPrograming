using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Product : IComparable<Product>
    {        
        public string Name;
        public int Id;
        public int Number;
        public int Price;
        public int SumPrice(int number, int price)
        {
            return number * price;
        }

        public Product(int id, string name, int number, int price)
        {
            this.Name = name;
            this.Id = id;
            this.Number = number;
            this.Price = price;           
        }

        public int CompareTo([AllowNull] Student other)
        {
            int check = Price.CompareTo(other.Price);
            return check;
        }
    }
}

