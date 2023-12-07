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
    public partial class AddOrderItemForm : Form
    {
        public Order orderItem = new Order();
        public Category categories;
        public string shop_name;
        public string typeProduct { get; set; }
        public AddOrderItemForm(string shopName, Order order)
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
            OrderItem prod = new OrderItem();

            if (name.TextLength > 0 &&
               index.TextLength > 0 &&
               producer.TextLength > 0 &&
               date.TextLength > 0 &&
               price.TextLength > 0 &&
               count.TextLength > 0 &&
               descr.TextLength > 0 &&
               comboBox1.SelectedItem != null)
            {
                prod.Car.CarItem.Name = name.Text;
                prod.Car.CarItem.Id = Int32.Parse(index.Text);
                prod.Car.CarItem.Producer = producer.Text;
                prod.Car.CarItem.CreationDate = date.Text;
                prod.Car.CarItem.Price = Int32.Parse(price.Text);
                prod.Car.CarItem.StockQuantity = Int32.Parse(count.Text);
                prod.Car.CarItem.Description = descr.Text;
                prod.Car.Category = typeProduct;

                orderItem.AddOrderItem(prod);
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
