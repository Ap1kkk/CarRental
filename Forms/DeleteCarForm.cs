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
        private string _salonName { get; set; }

        public DeleteCarForm(string salonName)
        {
            InitializeComponent();
            _salonName = salonName;
        }

        private void DeleteProductForm_Load(object sender, EventArgs e)
        {
        }

        private void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (IndexTxtBox.TextLength > 0)
            {
                DatabaseController.DeleteCarDB(_salonName, Int32.Parse(IndexTxtBox.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
