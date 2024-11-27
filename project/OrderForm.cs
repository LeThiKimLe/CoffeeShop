using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class OrderForm : Form
    {
        private Customer user;

        private List<CoffeeOrder> listOrder;
        public OrderForm(Customer requestUser)
        {
            InitializeComponent();
            user = requestUser;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            List<CoffeeOrder> orders = user.GetOrder();
            listOrder = orders;
            var orderData = orders.Select(o => new {
                id = o.Id.ToString(),
                date = o.Date.ToString(),
                total = o.GetOrderTotal().ToString(),
                state = o.GetOrderStatus(),
                payment = o.Payment
            }).ToList();
            orderView.DataSource = orderData;
        }

        private void orderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                DataGridViewRow row = orderView.Rows[e.RowIndex]; 
                int id = Convert.ToInt32(row.Cells["id"].Value);
                update_OrderItem(listOrder.Find(it => it.Id == id).ListItem);
            }
        }
        private void update_OrderItem(List<OrderItem> listItem)
        {
            string text = "";
            double total = 0;
            itemDesc.Text = text;
            foreach (OrderItem item in listItem)
            {
                text += $"+ {item.Coffee.Name} - Đơn giá: {item.Coffee.Price} đ x {item.Amount} ly: {item.Amount * item.Coffee.Price}đ \n";
                total += item.Amount * item.Coffee.Price;
            }
            itemDesc.Text = text;
            sumTxt.Text = total + " đ";
        }
    }
}
