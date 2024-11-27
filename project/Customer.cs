using System;
using System.Collections.Generic;
using project.BSLayer;

namespace project
{
    public class Customer : Person, IOrderable, IPrintable, IPayable
    {
        private List<string> orderHistory;
        private double balance;
        QueryCustomer cus = new QueryCustomer();

        public Customer(string name, string phone, int id, int role = 3) : base(name, phone, id, role)
        {
            orderHistory = new List<string>();
            //balance = initialBalance; // Initialize balance
        }

        // Public property for Balance
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        // Method to order coffee (implements IOrderable)
        public void OrderCoffee(Coffee coffee, int quantity)
        {
            double totalCost = coffee.Price * quantity;
            string orderDetails = $"{quantity}x {coffee.Name} @ ${coffee.Price} each - Total: ${totalCost}";
            orderHistory.Add(orderDetails);
            Console.WriteLine($"{Name} ordered {quantity} {coffee.Name}(s).");
        }

        // Method to pay (implements IPayable)
        public void Pay(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"{Name} paid ${amount}. Remaining balance: ${balance}");
            }
            else
            {
                Console.WriteLine($"{Name} has insufficient balance to pay ${amount}. Please add funds.");
            }
        }

        // Method to print customer details (implements IPrintable)
        public override void PrintDetails()
        {
            Console.WriteLine($"Customer ID: {ID}, Name: {Name}, Phone: {Phone}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine("Order History:");
            foreach (var order in orderHistory)
            {
                Console.WriteLine($"- {order}");
            }
        }

        // Additional method to get order history
        public List<string> GetOrderHistory()
        {
            return new List<string>(orderHistory); 
        }

        public void PlaceOrder(string itemName, int quantity)
        {
            string orderDetails = $"{quantity}x {itemName} - OrderID: {Guid.NewGuid()}";
            orderHistory.Add(orderDetails);
            Console.WriteLine($"{Name} placed an order for {quantity} {itemName}(s).");
        }

        public void CancelOrder(string orderId)
        {
            var orderToRemove = orderHistory.Find(order => order.Contains(orderId));
            if (orderToRemove != null)
            {
                orderHistory.Remove(orderToRemove);
                Console.WriteLine($"Order {orderId} has been canceled.");
            }
            else
            {
                Console.WriteLine($"Order {orderId} not found.");
            }
        }

        public List<Coffee> GetListMenu()
        {
            return cus.LoadMenuData();
        }

        public bool OrderCoffee(List<OrderItem> listItem)
        {
            return cus.AddOrder(ID, listItem);
        }

        public List<CoffeeOrder> GetOrder()
        {
            return cus.GetListOrder(ID);
        }
    }
}
