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
    public partial class PaymentForm : Form
    {
        private Customer user;
        private CoffeeOrder order;
        private double total;
        public bool paid;
        public PaymentForm(Person requestUser, CoffeeOrder paidOrder, double totalOrder)
        {
            InitializeComponent();
            user = (Customer)requestUser;
            order = paidOrder;
            paid = false;
            total = totalOrder;
            totalTxt.Text = total.ToString();
        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            if (user.PayOrder(order.Id, payMethodTxt.Text, total))
            {
                MessageBox.Show("Đã thanh toán đơn hàng thành công", "Thông báo");
                paid = true;
                this.Close();
            }    
        }
    }
}
