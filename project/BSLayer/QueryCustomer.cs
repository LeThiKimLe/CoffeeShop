﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BSLayer
{
    class QueryCustomer
    {
        public List<Coffee> LoadMenuData()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            // Truy vấn dữ liệu sử dụng LINQ
            var query = (from item in db.Menus select item).ToList();
            List<Coffee> listItem = new List<Coffee>();
            foreach (Menu item in query)
            {
                listItem.Add(new Coffee(item.name, (double)item.price));
            }
            return listItem;
        }
        public bool AddOrder(int userId, List<OrderItem> coffeeItems)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                // Tạo đơn hàng mới
                int newID = context.Orders.Max(o => o.id) + 1;
                Order newOrder = new Order();
                newOrder.id = newID;
                newOrder.customer_id = userId;
                newOrder.date = DateTime.Now;

                // Sử dụng LINQ để thêm các OrderItem vào đơn hàng
                int newDetailID = context.OrderDetails.Max(o => o.id) + 1;
                foreach (OrderItem item in coffeeItems)
                {
                    OrderDetail orderItem = new OrderDetail();
                    var drink = context.Menus.FirstOrDefault(it => it.name == item.Coffee.Name);
                    orderItem.id = newDetailID;
                    orderItem.drink_id = drink.id;
                    orderItem.order_id = newID;
                    orderItem.price = drink.price;
                    orderItem.amount = item.Amount;
                    orderItem.state = false;
                    newOrder.OrderDetails.Add(orderItem);
                    newDetailID += 1;
                }

                // Thêm Order vào DbContext
                context.Orders.InsertOnSubmit(newOrder);

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SubmitChanges();

                return true;
            } catch (Exception err)
            {
                throw err;
                //return false;
            }
        }

        public List<CoffeeOrder> GetListOrder(int userId)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            // Truy vấn dữ liệu sử dụng LINQ
            var query = (from item in db.Orders where item.customer_id == userId select item).ToList();
            List<CoffeeOrder> listOrder = new List<CoffeeOrder>();
            foreach (Order item in query)
            {
                CoffeeOrder newOrder = new CoffeeOrder(item.id, (DateTime)item.date, item.payment, (int)item.customer_id);
                newOrder.ListItem = new List<OrderItem>();
                foreach(OrderDetail detail in item.OrderDetails)
                {
                    newOrder.ListItem.Add(new OrderItem(new Coffee(detail.Menu.name, (double)detail.price), (int)detail.amount, (bool)detail.state));
                }
                listOrder.Add(newOrder);
            }
            return listOrder;
        }
    }
        
}