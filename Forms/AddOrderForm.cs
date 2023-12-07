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
    public partial class AddOrderForm : Form
    {
        private string _salonName { get; set; }
        private Order _orderItem { get; set; } = new Order();

        public AddOrderForm(string salonName, Order newOrder)
        {
            InitializeComponent();
            _salonName = salonName;
            _orderItem = newOrder;
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            if (IndexTxt.TextLength > 0 &&
              descTxt.TextLength > 0 &&
              priceTxt.TextLength > 0)
            {
                _orderItem.OrderId = Int32.Parse(IndexTxt.Text);
                _orderItem.Description = descTxt.Text;
                _orderItem.TotalPrice = Int32.Parse(priceTxt.Text);
                DatabaseController.AddOrderDB(_salonName, _orderItem);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOLineItemBtn_Click(object sender, EventArgs e)
        {
            AddOrderItemForm addOrderItemForm = new AddOrderItemForm(_salonName, _orderItem);
            addOrderItemForm.Show();
            Close();
        }
    }
}
