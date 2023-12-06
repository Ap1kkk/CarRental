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
    public partial class DeleteCarForm : Form
    {
      public string  name_shop { get; set; }
        public DeleteCarForm(string shopName)
        {
            InitializeComponent();
            name_shop = shopName;
        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (IndexTxtBox.TextLength > 0)
            {
                ContrDB.DeleteProductDB(name_shop, Int32.Parse(IndexTxtBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
