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
    public partial class CarsInfoForm : Form
    {
        private string _salonName { get; set; }
        private SalonController _shopController { get; set; }
        private List<Car> _cars { get; set; }
        public CarsInfoForm(string salonName, List<Car> cars)
        {
            InitializeComponent();
            _salonName = salonName;
            _cars = cars;

            _shopController = new SalonController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Car item in _cars)
            {
                string name = item.CarItem.Name;
                string dateCreate = item.CarItem.CreationDate;
                int id = item.CarItem.Id;
                string producer = item.CarItem.Producer;
                int price = item.CarItem.Price;
                int count = item.CarItem.StockQuantity;
                string description = item.CarItem.Description;
                string category = item.Category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Car item in _cars)
            {
                string name = item.CarItem.Name;
                string dateCreate = item.CarItem.CreationDate;
                int id = item.CarItem.Id;
                string producer = item.CarItem.Producer;
                int price = item.CarItem.Price;
                int count = item.CarItem.StockQuantity;
                string description = item.CarItem.Description;
                string category = item.Category;
                dataGridView1.Rows.Add(name, dateCreate, id, producer, price, count, description, category);
                dataGridView1.Rows[index++].ReadOnly = true;
            }

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm(_salonName);
            addCarForm.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            DeleteCarForm deleteCarForm = new DeleteCarForm(_salonName);
            deleteCarForm.Show();
        }
    }
}
