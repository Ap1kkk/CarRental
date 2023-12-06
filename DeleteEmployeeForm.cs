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
    public partial class DeleteEmployeeForm : Form
    {
        public string name_shop { get; set; }

        public DeleteEmployeeForm(string shopName)
        {
            InitializeComponent();
            name_shop = shopName;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.TextLength > 0 && LastNameTxtBox.TextLength > 0)
            {
                ContrDB.DeleteEmployeeDB(name_shop, NameTxtBox.Text, LastNameTxtBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
