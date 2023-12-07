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
    public partial class EmployeesInfoForm : Form
    {
        private string _salonName { get; set; }
        private SalonController _shopController { get; set; }
        private List<Employee> _employees { get; set; }

        public EmployeesInfoForm(string salonName, List<Employee> employee)
        {
            InitializeComponent();
            _salonName = salonName;
            _employees = employee;

            _shopController = new SalonController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Employee item in _employees)
            {
                string name = item.Firstname;
                string lname = item.Lastname;
                string phone = item.PhoneNumber;
                string status = item.Status;
                string exp = item.Experience;
                string BeginWork = item.WorkBegin;
                string EndWork = item.WorkEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Employee item in _employees)
            {
                string name = item.Firstname;
                string lname = item.Lastname;
                string phone = item.PhoneNumber;
                string status = item.Status;
                string exp = item.Experience;
                string BeginWork = item.WorkBegin;
                string EndWork = item.WorkEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(_salonName);
            addEmployeeForm.Show();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployeeForm deleteEmployeeForm = new DeleteEmployeeForm(_salonName);
            deleteEmployeeForm.Show();
        }
    }
}
