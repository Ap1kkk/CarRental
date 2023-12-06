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
    public partial class InfoAboutOrdersForm : Form
    {
        public string shop_name { get; set; }
        public SalonContr control;
        public List<Order> orders { get; set; }

        public Order orderTemplate { get; set; }
        public InfoAboutOrdersForm(string shopName, List<Order> ordersList)
        {
            InitializeComponent();
            shop_name = shopName;
            orders = ordersList;
            //Обработчик события обновления
            control = new SalonContr();
            control.update += UpdateTable;

            int index = 0;
            //Добавление в таблицу данных
            foreach (Order item in orders)
            {
               
                int id = item.order_num;
                string desc = item.descr;
                string prodList = "";
              foreach(OrderLineitem orderItem in item.GetOrdersFields())
                {
                    prodList += orderItem.product.product.name + "; ";
                }
    
                int final_price = item.total_price;

                dataGridView1.Rows.Add(id, desc, prodList, final_price);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrderForm addProd = new AddOrderForm(shop_name, orderTemplate);
            addProd.Show();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            //Добавление в таблицу данных
            foreach (Order item in orders)
            {

                int id = item.order_num;
                string desc = item.descr;
                string prodList = "";
                foreach (OrderLineitem orderItem in item.GetOrdersFields())
                {
                    prodList += orderItem.product.product.name + "; ";
                }

                int final_price = item.total_price;
                dataGridView1.Rows.Add(id, desc, prodList, final_price);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
    }
}
