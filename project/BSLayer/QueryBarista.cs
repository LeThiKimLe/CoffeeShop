using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BSLayer
{
    class QueryBarista
    {
        public List<CoffeeOrder> GetListOrderedDrink()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            // Truy vấn dữ liệu sử dụng LINQ
            var ordersWithPendingItems = context.Orders.Where(o => context.OrderDetails.Any(od => od.order_id == o.id && od.state == false));
            List<CoffeeOrder> listOrder = new List<CoffeeOrder>();
            foreach (Order item in ordersWithPendingItems)
            {
                CoffeeOrder newOrder = new CoffeeOrder(item.id, (DateTime)item.date, item.payment, (int)item.customer_id);
                newOrder.ListItem = new List<OrderItem>();
                foreach (OrderDetail detail in item.OrderDetails)
                {
                    newOrder.ListItem.Add(new OrderItem(newOrder.Id, new Coffee(detail.Menu.id, detail.Menu.name, (double)detail.price), (int)detail.amount, (bool)detail.state));
                }
                listOrder.Add(newOrder);
            }
            return listOrder;
        }

        public List<Material> GetListIngredient()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var objectMaterial = from item in context.Ingredients where item.active == true select item;
            List<Material> listOrder = objectMaterial.Select(o => new Material(o.id, o.name, (int)o.count, o.unit)).ToList();
            return listOrder;
        }

        public List<Formula> GetCoffeeFomular(int coffeeId)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var formula = from item in context.Recipes where item.drink_id == coffeeId select item;
            return formula.Select(o => new Formula(new Coffee(o.Menu.id, o.Menu.name, (double)o.Menu.price), new Material(o.Ingredient.id, o.Ingredient.name, (int)o.Ingredient.count, o.Ingredient.unit), (double)o.amount)).ToList();
        }

        public string CheckAvailable(int coffeeId, int amount)
        {
            using (var context = new DataClasses1DataContext())
            {
                List<Formula> formula = GetCoffeeFomular(coffeeId);

                List<Material> material = GetListIngredient();

                var result = from ingredient in formula
                             join inv in material on ingredient.Material.Id equals inv.Id
                             where inv.Count < ingredient.Amount * amount
                             select inv.Name;

                if (result.Any())
                {
                    return "Nguyên liệu không đủ. Thiếu: " + string.Join(", ", result);
                }
                else
                {
                    return "Đủ nguyên liệu";
                }
            }

        }

        public string PrepareCoffee(int orderId, int itemId)
        {
            var context = new DataClasses1DataContext();
            var orderDetail = context.OrderDetails.FirstOrDefault(o => o.order_id == orderId && o.drink_id == itemId);
            var formuala = GetCoffeeFomular(itemId);
            if (orderDetail != null)
            {
                orderDetail.state = true;
                context.SubmitChanges();

                foreach (var ingredient in formuala) 
                { 
                    var inv = context.Ingredients.FirstOrDefault(i => i.id == ingredient.Material.Id); 
                    if (inv != null) 
                    {
                        inv.count -= (int)ingredient.Amount * orderDetail.amount; 
                    } 
                }
                context.SubmitChanges();
                return "success";
            }
            else
                return "fail";
        }
    }
}
