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
    public partial class InfoAboutEmployeesForm : Form
    {
        public string name_shop { get; set; }
        public SalonContr control;
        public List<Employee> employees { get; set; }
        public InfoAboutEmployeesForm(string shopName, List<Employee> empl)
        {
            InitializeComponent();
            name_shop = shopName;
            employees = empl;
            //Обработчик события обновления
            control = new SalonContr();
            control.update += UpdateTable;

            int index = 0;
            //Добавление в таблицу данныхф
            foreach (Employee item in employees)
            {
                string name = item.firstName;
                string lname = item.lastName;
                string phone = item.PhoneNumber;
                string status = item.status;
                string exp = item.experience;
                string BeginWork = item.workBegin;
                string EndWork = item.workEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Employee item in employees)
            {
                string name = item.firstName;
                string lname = item.lastName;
                string phone = item.PhoneNumber;
                string status = item.status;
                string exp = item.experience;
                string BeginWork = item.workBegin;
                string EndWork = item.workEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addProd = new AddEmployeeForm(name_shop);
            addProd.Show();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployeeForm addProd = new DeleteEmployeeForm(name_shop);
            addProd.Show();
        }
    }
}
