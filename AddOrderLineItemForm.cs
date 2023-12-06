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
    public partial class AddOrderLineItemForm : Form
    {
        public Order orderItem = new Order();
        public Category categories;
        public string shop_name;
        public string typeProduct { get; set; }
        public AddOrderLineItemForm(string shopName, Order order)
        {
            InitializeComponent();
            shop_name = shopName;
            categories = new Category();
            foreach (string type in categories.GetCategories())
            {
                comboBox1.Items.Add(type);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
           
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            OrderLineitem prod = new OrderLineitem();

            if (name.TextLength > 0 &&
               index.TextLength > 0 &&
               producer.TextLength > 0 &&
               date.TextLength > 0 &&
               price.TextLength > 0 &&
               count.TextLength > 0 &&
               descr.TextLength > 0 &&
               comboBox1.SelectedItem != null)
            {
                prod.product.product.name = name.Text;
                prod.product.product.id = Int32.Parse(index.Text);
                prod.product.product.producer = producer.Text;
                prod.product.product.date_create = date.Text;
                prod.product.product.price = Int32.Parse(price.Text);
                prod.product.product.count = Int32.Parse(count.Text);
                prod.product.product.description = descr.Text;
                prod.product.category = typeProduct;

                orderItem.AddOrderLineItem(prod);
                AddOrderForm addOrderForm = new AddOrderForm(shop_name, orderItem);
                addOrderForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            typeProduct = selectedState;
        }
    }
}
