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
    public partial class QuantityDialog : Form
    {
        public int Quantity { get; private set; }
        public QuantityDialog(string coffeeName)
        {
            InitializeComponent();
            coffee.Text = coffeeName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Quantity = int.Parse(quantityTxt.Text);
                if (Quantity >=0 )
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            
        }
    }
}
