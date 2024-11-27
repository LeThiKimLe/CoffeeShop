using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public class Barista : Person
    {
        private string specialty;
        private int totalCoffeesPrepared;

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
        public void PrepareCoffee(Coffee coffee)
        {
            Console.WriteLine($"Barista {Name} is preparing {coffee.Name}...");
            totalCoffeesPrepared++;
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
    }
}