using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.BSLayer;
namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QueryLogin lg = new QueryLogin();

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Person user = lg.Login(usernameTxt.Text, passwordTxt.Text);
            if (user != null) {
                // Đóng form hiện tại
                this.Hide();
                if (user is Manager)
                {
                    ManagerForm managerForm = new ManagerForm(user);
                    managerForm.ShowDialog();
                }
                else if (user is Barista)
                {
                    BaristaForm baristaForm = new BaristaForm(user);
                    baristaForm.ShowDialog();
                }
                else {
                    CustomerForm customerForm = new CustomerForm(user);
                    customerForm.ShowDialog();
                }
                this.Show();
            } else
            {
                errorMsg.Visible = true;
            }


        }
    }
}
