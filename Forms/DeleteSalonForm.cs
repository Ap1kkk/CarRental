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
    public partial class DeleteSalonForm : Form
    {
        public DeleteSalonForm()
        {
            InitializeComponent();
        }

        private void DeleteShop_Click(object sender, EventArgs e)
        {
            if (txtBoxDeleteNameShop.TextLength > 0)
            {
                DatabaseController.DeleteSalonDB(txtBoxDeleteNameShop.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
