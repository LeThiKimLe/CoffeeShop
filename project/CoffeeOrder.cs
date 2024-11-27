using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class CoffeeOrder
    {
        private int id; 
        private DateTime date; 
        private string payment; 
        private int userId;
        private List<OrderItem> listItem;

        public int Id { get { return id; } set { id = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public string Payment { get { return payment; } set { payment = value; } }
        public int UserId { get { return userId; } set { userId = value; } }

        public List<OrderItem> ListItem
        {
            get { return listItem; }
            set { listItem = value; }
        }

        public CoffeeOrder(int id, DateTime date, string payment, int userId)
        { 
            this.id = id; 
            this.date = date; 
            this.payment = payment; 
            this.userId = userId; 
        }

        public double GetOrderTotal()
        {
            double total = 0;
            foreach(OrderItem item in listItem)
            {
                total += item.Coffee.Price * item.Amount;
            }
            return total;
        }

        public string GetOrderStatus()
        {
            int totalCount = 0;
            int prepared = 0;
            foreach (OrderItem item in listItem)
            {
                totalCount += item.Amount;
                if (item.Status == true)
                    prepared += item.Amount;
            }
            if (totalCount == prepared)
                return "Đã hoàn thành";
            else if (prepared == 0)
                return "Đang nhận đơn";
            else
                return $"Đang thực hiện {Math.Round((double)prepared/totalCount*100, 2)}%";
        }
    }
}
