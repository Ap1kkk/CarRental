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
        private string _salonName { get; set; }
        private Category _categories { get; set; }
        private string carCategory { get; set; }

        public AddCarForm(string salonName)
        {
            InitializeComponent();
            _categories = new Category();
            _salonName = salonName;
            foreach( string type in _categories.GetCategories())
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
                Car car = new Car();
                car.CarItem.Name = name.Text;
                car.CarItem.Id = Int32.Parse(index.Text);
                car.CarItem.Producer = producer.Text;
                car.CarItem.CreationDate = date.Text;
                car.CarItem.Price = Int32.Parse(price.Text);
                car.CarItem.StockQuantity = Int32.Parse(count.Text);
                car.CarItem.Description = descr.Text;
                car.Category = carCategory;

                DatabaseController.AddCarDB(_salonName, car);
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
            carCategory = selectedState;
        }
    }
}
