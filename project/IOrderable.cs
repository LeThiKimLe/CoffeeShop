using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    public interface IOrderable
    {
        void PlaceOrder(string itemName, int quantity);
        void CancelOrder(string orderId);
    }
}