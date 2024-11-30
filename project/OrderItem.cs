using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class OrderItem
    {
        private int orderId;
        private Coffee coffee;
        private int amount;
        private bool status;
        public OrderItem(int orderId, Coffee coffee, int amount, bool prepared = false) 
        { 
            this.coffee = coffee;
            this.amount = amount;
            status = prepared;
            this.orderId = orderId;
        }

        public Coffee Coffee
        {
            get { return coffee; }
            set { coffee = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }


    }
}
