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
    public partial class AddEmployeeForm : Form
    {
        public string shop_name;
        public AddEmployeeForm(string ShopName)
        {
            InitializeComponent();
            shop_name = ShopName;
        }
        
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            lastname.Text = "";
            phone.Text = "";
            status.Text = "";
            experiense.Text = "";
            workBegin.Text = "";
            workEnd.Text = "";
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (name.TextLength > 0 &&
               lastname.TextLength > 0 &&
               phone.TextLength > 0 &&
               status.TextLength > 0 &&
               experiense.TextLength > 0 &&
               workBegin.TextLength > 0 &&
               workEnd.TextLength > 0 )
            {
                Employee worker = new Employee();
                worker.firstName = name.Text;
                worker.lastName = lastname.Text;
                worker.PhoneNumber = phone.Text;
                worker.status = status.Text;
                worker.experience = experiense.Text;
                worker.workBegin = workBegin.Text;
                worker.workEnd = workEnd.Text;

                ContrDB.AddEmployeeDB(shop_name, worker);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
