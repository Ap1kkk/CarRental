using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class AddOrderForm : Form
    {
        public string shop_name { get; set; }
        public Order order_item = new Order();
        public AddOrderForm(string ShopName, Order new_order)
        {
            InitializeComponent();
            shop_name = ShopName;
            order_item = new_order;
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            if (IndexTxt.TextLength > 0 &&
              descTxt.TextLength > 0 &&
              priceTxt.TextLength > 0)
            {
                order_item.order_num = Int32.Parse(IndexTxt.Text);
                order_item.descr = descTxt.Text;
                order_item.total_price = Int32.Parse(priceTxt.Text);
                ContrDB.AddOrderDB(shop_name, order_item);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOLineItemBtn_Click(object sender, EventArgs e)
        {
            AddOrderLineItemForm OLineitem = new AddOrderLineItemForm(shop_name, order_item);
            OLineitem.Show();
            Close();
        }
    }
}
