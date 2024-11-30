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
    public partial class BaristaForm : Form
    {
        private Barista user;
        private List<CoffeeOrder> listOrder;
        private OrderItem currentItem;
        public BaristaForm(Person loginUser)
        {
            InitializeComponent();
            user = (Barista)loginUser;
            LoadOrderData();
            LoadMaterialList();
        }

        public void LoadOrderData()
        {
            List<CoffeeOrder> orders = user.GetListOrder();
            listOrder = orders;
            var listItem = orders.SelectMany(o => o.ListItem, (order, orderItem) =>
                                 new {
                                     orderId = order.Id,
                                     name = orderItem.Coffee.Name, 
                                     amount = orderItem.Amount.ToString(), 
                                     state = orderItem.Status == true ? "Đã làm" : "Chưa làm"
                                 }).ToList();
            coffeeView.DataSource = listItem;
            coffeeName.Text = "";
            coffeeAmount.Text = "";
            coffeeReceipt.Text = "";
            currentItem = null;
            makeCoffeeBtn.Enabled = false;
        }

        public void LoadMaterialList()
        {
            storeView.DataSource = user.GetListMaterial();
        }
        private void coffeeView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = coffeeView.Rows[e.RowIndex];
                var orderID = row.Cells["orderId"].Value.ToString();
                Color color = GetColorForOrder(orderID);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = color;
                }
            }
        }

        private Color GetColorForOrder(string orderId)
        {
            int hash = orderId.GetHashCode();
            Random rand = new Random(hash);
            int r = 128 + rand.Next(128);
            int g = 128 + rand.Next(128);
            int b = 128 + rand.Next(128); // Giới hạn trong khoảng 128-255
            return Color.FromArgb(r, g, b);
        }

        private void coffeeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = coffeeView.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["orderId"].Value);
                coffeeName.Text = row.Cells["name"].Value.ToString();
                coffeeAmount.Text = row.Cells["amount"].Value.ToString();
                OrderItem orderItem = listOrder.Where(o => o.Id == orderId).SelectMany(o => o.ListItem).FirstOrDefault(od => od.Coffee.Name == coffeeName.Text);
                currentItem = orderItem;
                coffeeReceipt.Text = orderItem.Coffee.Formular();
                if (currentItem.Status == false)
                    makeCoffeeBtn.Enabled = true;
                else
                    makeCoffeeBtn.Enabled = false;
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadOrderData();
            LoadMaterialList();
        }

        private void makeCoffeeBtn_Click(object sender, EventArgs e)
        {
            string result = user.PrepareCoffee(currentItem);
            if (result == "success")
            {
                MessageBox.Show("Đã pha chế thành công", "Thành công");
                LoadOrderData();
                LoadMaterialList();
            } else
            {
                MessageBox.Show(result, "Thông báo");
            }    
        }
    }
}
