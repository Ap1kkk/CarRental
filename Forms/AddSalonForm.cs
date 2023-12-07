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
    public partial class AddSalonForm : Form
    {
        public AddSalonForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddShopForm_Load(object sender, EventArgs e)
        {

        }

        private void AddShopBtn_Click(object sender, EventArgs e)
        {
            if (name.TextLength > 0 &&
                phoneNumber.TextLength > 0 &&
                website.TextLength > 0 &&
                addres.TextLength> 0 &&
                workBegin.TextLength > 0 &&
                workEnd.TextLength > 0)
            {
                CarSalon shop = new CarSalon();
                shop.Name =  name.Text;
                shop.PhoneNumber = phoneNumber.Text;
                shop.Website = website.Text;
                shop.Adress = addres.Text;
                shop.BeginWork = workBegin.Text;
                shop.EndWork = workEnd.Text;

                DatabaseController.AddSalonDB(shop);
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
            phoneNumber.Text = "";
            website.Text = "";
            addres.Text = "";
            workBegin.Text = "";
            workEnd.Text = "";
        }
    }
}
