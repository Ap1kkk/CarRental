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
    public partial class InfoAboutProductsForm : Form
    {
        public string name_shop { get; set; }
        public SalonContr control;
        public List<Car> products { get; set; }
        public InfoAboutProductsForm(string nameShop, List<Car> goods)
        {
            InitializeComponent();
            name_shop = nameShop;
            products = goods;
            //Обработчик события обновления
            control = new SalonContr();
            control.update += UpdateTable;

            int index = 0;
            //Добавление в таблицу данныхф
            foreach (Car item in products)
            {
                string name = item.product.name;
                string dateCreate = item.product.date_create;
                int id = item.product.id;
                string producer = item.product.producer;
                int price = item.product.price;
                int count = item.product.count;
                string description = item.product.description;
                string category = item.category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Car item in products)
            {
                string name = item.product.name;
                string dateCreate = item.product.date_create;
                int id = item.product.id;
                string producer = item.product.producer;
                int price = item.product.price;
                int count = item.product.count;
                string description = item.product.description;
                string category = item.category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddCarForm addProd = new AddCarForm(name_shop);
            addProd.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DeleteCarForm addProd = new DeleteCarForm(name_shop);
            addProd.Show();
        }
    }
}
