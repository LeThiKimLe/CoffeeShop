using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public class Coffee
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Coffee(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{Name}";
            //return $"{Name} ({Size}): ${Price}\nDescription: {Description}";
        }
    }
}