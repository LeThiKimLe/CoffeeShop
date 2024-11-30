using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project.BSLayer;

namespace project
{
    public class Coffee
    {
        private string name;
        private double price;
        private int id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Coffee(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{Name}";
            //return $"{Name} ({Size}): ${Price}\nDescription: {Description}";
        }

        public string Formular()
        {
            QueryCoffee query = new QueryCoffee();
            return query.GetCoffeeFormula(Id);
        }
    }
}