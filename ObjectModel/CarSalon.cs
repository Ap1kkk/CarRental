using System;
using System.Collections.Generic;


namespace CarRental
{
    public class CarSalon
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Adress { get; set; }
        public string BeginWork { get; set; }
        public string EndWork { get; set; }

        private List<Car> _carsList { get; set; }
        private List<Employee> _employees { get; set; }
        private List<Order> _orders { get; set; }

        public CarSalon()
        {
            _carsList = new List<Car>();
            _employees = new List<Employee>();
            _orders = new List<Order>();
        }

        public bool AddProduct(Car newCar)
        {
            foreach (Car car in _carsList)
            {
                if (car.CarItem.Name == newCar.CarItem.Name)
                    return false;
            }
            _carsList.Add(newCar);
            return true;
        }

        public bool DeleteProduct(int index)
        {
            foreach (Car car in _carsList)
            {
                if (index == car.CarItem.Id)
                {
                    return _carsList.Remove(car);
                }
            }

            return false;
        }

        public IReadOnlyCollection<Car> GetCars()
        {
            return _carsList.AsReadOnly();
        }

        public IReadOnlyCollection<Employee> GetEmployees()
        {
            return _employees.AsReadOnly();
        }
        public IReadOnlyCollection<Order> GetOrders()
        {
            return _orders.AsReadOnly();
        }

        public bool AddEmployee(Employee newEmployee)
        {
            foreach (Employee employee in _employees)
            {
                if ((employee.Firstname == newEmployee.Firstname) && (employee.Lastname == newEmployee.Lastname))
                    return false;
            }
            _employees.Add(newEmployee);
            return true;
        }

        public bool DeleteEmployee(string firstname, string lastname)
        {
            foreach (Employee employee in _employees)
            {
                if ((employee.Firstname == firstname) && (employee.Lastname == lastname))
                {
                    return _employees.Remove(employee);
                }
            }

            return false;
        }
        public bool AddOrder(Order newOrder)
        {
            foreach (Order order in _orders)
            {
                if (order.OrderId == newOrder.OrderId)
                    return false;
            }
            _orders.Add(newOrder);
            return true;
        }
        public bool DeleteOrder(int index)
        {
            foreach (Order order in _orders)
            {
                if (index == order.OrderId)
                {
                    return _orders.Remove(order);
                }
            }
            return false;
        }
    }
}