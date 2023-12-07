using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class MainController
    {
        public delegate void WorkDone();
        public event WorkDone OnUpdate;

        private List<CarSalon> _carSalons;
        public int CountShop { get; }
        public MainController()
        {
            DatabaseController.LoadFromFile();
            _carSalons = new List<CarSalon>(DatabaseController.GetSalons());
            CountShop = _carSalons.Count;
        }

        public void Save()
        {
            DatabaseController.SaveToFile();
        }

        private void Signal(object sender, EventArgs e)
        {
            _carSalons = new List<CarSalon>(DatabaseController.GetSalons());
            OnUpdate?.Invoke();
        }

        public void AddSalon()
        {
            AddSalonForm addShop = new AddSalonForm();
            addShop.FormClosed += Signal;
            addShop.Show();
        }

        public void DeleteSalon()
        {
            DeleteSalonForm deleteShop = new DeleteSalonForm();
            deleteShop.FormClosed += Signal;
            deleteShop.Show();
        }

        public IReadOnlyList<CarSalon> GetShop()
        {
            return _carSalons.AsReadOnly();
        }

        public void ShowProductsInfo(string salonName)
        {
            foreach (CarSalon salon in _carSalons)
            {
                if (salon.Name == salonName)
                {
                    List<Car> cars = new List<Car>(salon.GetCars());
                    CarsInfoForm carInfoForm = new CarsInfoForm(salonName, cars);
                    carInfoForm.FormClosed += Signal;
                    carInfoForm.Show();                 
                }
            }
        }

        public void ShowEmployeeInfo(string salonName)
        {
            foreach (CarSalon salon in _carSalons)
            {
                if (salon.Name == salonName)
                {
                    List<Employee> employees = new List<Employee>(salon.GetEmployees());
                    EmployeesInfoForm employeeInfoForm = new EmployeesInfoForm(salonName, employees);
                    employeeInfoForm.FormClosed += Signal;
                    employeeInfoForm.Show();

                }
            }
        }

        public void OrderInfo(string salonName)
        {
            foreach (CarSalon salon in _carSalons)
            {
                if (salon.Name == salonName)
                {
                    List<Order> orders = new List<Order>(salon.GetOrders());
                    OrdersInfoForm ordersInfoForm = new OrdersInfoForm(salonName, orders);
                    ordersInfoForm.FormClosed += Signal;
                    ordersInfoForm.Show();
                }
            }
        }
    }
}
