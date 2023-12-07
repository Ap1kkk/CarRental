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
        private string _salonName { get; set; }

        public AddEmployeeForm(string salonName)
        {
            InitializeComponent();
            _salonName = salonName;
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
                worker.Firstname = name.Text;
                worker.Lastname = lastname.Text;
                worker.PhoneNumber = phone.Text;
                worker.Status = status.Text;
                worker.Experience = experiense.Text;
                worker.WorkBegin = workBegin.Text;
                worker.WorkEnd = workEnd.Text;

                DatabaseController.AddEmployeeDB(_salonName, worker);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
