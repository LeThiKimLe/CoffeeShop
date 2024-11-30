using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project.BSLayer;

namespace project
{
    public class Barista : Person
    {
        private string specialty;
        private int totalCoffeesPrepared;
        private QueryBarista query = new QueryBarista();

        public Barista(string name, string phone, int id, int role = 2) : base(name, phone, id, role)
        {
            this.specialty = specialty;
            this.totalCoffeesPrepared = 0;
        }
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }
        public int TotalCoffeesPrepared 
        {
            get { return totalCoffeesPrepared; }
            set { totalCoffeesPrepared = value; }
        }
        public string PrepareCoffee(OrderItem item)
        {
            string checkStr = query.CheckAvailable(item.Coffee.Id, item.Amount);
           if (checkStr == "Đủ nguyên liệu")
           {
                return query.PrepareCoffee(item.OrderId, item.Coffee.Id);
           } else
           {
                return checkStr;
           }

        }

        public void ServeCoffee(Coffee coffee, Customer customer)
        {
            Console.WriteLine($"Barista {Name} served {coffee.Name} to {customer.Name}.");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Barista ID: {ID}, Name: {Name}, Phone: {Phone}");
            Console.WriteLine($"Specialty: {Specialty}");
            Console.WriteLine($"Total Coffees Prepared: {totalCoffeesPrepared}");
        }

        public List<CoffeeOrder> GetListOrder()
        {
            return query.GetListOrderedDrink();
        }

        public List<Material> GetListMaterial()
        {
            return query.GetListIngredient();
        }
    }
}