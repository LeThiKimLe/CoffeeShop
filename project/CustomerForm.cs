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
    public partial class CustomerForm : Form
    {
        private Customer user;
        private int currentLabelYPosition = 20;
        List<OrderItem> listItem = new List<OrderItem>();
        public CustomerForm(Person loginUser)
        {
            InitializeComponent();
            user = (Customer)loginUser;
            orderDesc.Text = "";
            LoadMenuData();
        }
        private void LoadMenuData()
        {
            menu.DataSource = user.GetListMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột nào được nhấn
            if (e.ColumnIndex == menu.Columns["choose"].Index && e.RowIndex >= 0)
            {
                // Lấy tên món từ DataGridView
                string itemName = menu.Rows[e.RowIndex].Cells["name"].Value.ToString();
                double unit = Convert.ToDouble(menu.Rows[e.RowIndex].Cells["price"].Value.ToString());
                // Hiển thị dialog nhập số lượng
                using (QuantityDialog quantityDialog = new QuantityDialog(itemName))
                {
                    if (quantityDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lấy số lượng từ dialog
                        int quantity = quantityDialog.Quantity;
                        var existingOrderItem = listItem.FirstOrDefault(item => item.Coffee.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
                        if (existingOrderItem != null)
                        {
                            if (quantity != 0)
                                existingOrderItem.Amount = quantity;
                            else
                                listItem.Remove(existingOrderItem);
                        } else
                        {
                            if (quantity != 0)
                                listItem.Add(new OrderItem(new Coffee(itemName, unit), quantity));
                        }
                        update_Order();
                    }
                }
            }
        }
        private void update_Order()
        {
            string text = "";
            double total = 0;
            orderDesc.Text = text;
            foreach (OrderItem item in listItem)
            {
                text += $"+ {item.Coffee.Name} x {item.Amount} ly: {item.Amount * item.Coffee.Price}đ \n";
                total += item.Amount * item.Coffee.Price;
            }
            orderDesc.Text = text;
            totalTxt.Text = total + " đ";
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(user);
            orderForm.Show();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (listItem.Count > 0)
            {
                if (user.OrderCoffee(listItem)) {
                    MessageBox.Show("Đặt hàng thành công. Vui lòng click Xem đơn hàng để xem lại", "Thành công");
                }
            }
        }
    }
}
