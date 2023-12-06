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
    public partial class AddCarForm : Form
    {
        public string shop_name { get; set; }
        public Category categories;
        public string typeProduct { get; set; }
        public AddCarForm(string nameShop)
        {
            InitializeComponent();
            categories = new Category();
            shop_name = nameShop;
            foreach( string type in categories.GetCategories())
            {
                comboBox1.Items.Add(type);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (name.TextLength > 0 &&
                index.TextLength > 0 &&
                producer.TextLength > 0 &&
                date.TextLength > 0 &&
                price.TextLength > 0 &&
                count.TextLength > 0 &&
                descr.TextLength > 0 &&
                comboBox1.SelectedItem != null)
            {
                Car prod = new Car();
                prod.product.name = name.Text;
                prod.product.id = Int32.Parse(index.Text);
                prod.product.producer = producer.Text;
                prod.product.date_create = date.Text;
                prod.product.price = Int32.Parse(price.Text);
                prod.product.count = Int32.Parse(count.Text);
                prod.product.description = descr.Text;
                prod.category = typeProduct;

                ContrDB.AddProductDB(shop_name, prod);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            index.Text = "";
            producer.Text = "";
            date.Text = "";
            price.Text = "";
            count.Text = "";
            descr.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            typeProduct = selectedState;
        }
    }
}
