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
    public partial class OrdersInfoForm : Form
    {
        private string _salonName { get; set; }
        private SalonController _shopController { get; set; }
        public List<Order> _orders { get; set; }
        public Order _order { get; set; }

        public OrdersInfoForm(string shopName, List<Order> ordersList)
        {
            InitializeComponent();
            _salonName = shopName;
            _orders = ordersList;

            _shopController = new SalonController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Order item in _orders)
            {
               
                int id = item.OrderId;
                string description = item.Description;
                string carList = "";
                foreach(OrderItem orderItem in item.GetOrdersFields())
                {
                    carList += orderItem.Car.CarItem.Name + "; ";
                }
    
                int totalPrice = item.TotalPrice;
                dataGridView1.Rows.Add(id, description, carList, totalPrice);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(_salonName, _order);
            addOrderForm.Show();
        }

        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Order item in _orders)
            {
                int id = item.OrderId;
                string desc = item.Description;
                string prodList = "";
                foreach (OrderItem orderItem in item.GetOrdersFields())
                {
                    prodList += orderItem.Car.CarItem.Name + "; ";
                }

                int final_price = item.TotalPrice;
                dataGridView1.Rows.Add(id, desc, prodList, final_price);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
    }
}
