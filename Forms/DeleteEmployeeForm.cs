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
        private string _salonName { get; set; }

        public DeleteEmployeeForm(string salonName)
        {
            InitializeComponent();
            _salonName = salonName;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.TextLength > 0 && LastNameTxtBox.TextLength > 0)
            {
                DatabaseController.DeleteEmployeeDB(_salonName, NameTxtBox.Text, LastNameTxtBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
