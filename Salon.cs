using System;
using System.Collections.Generic;


namespace CarRental
{
    public class Salon
    {
        public string name { get; set; }
        public string PhoneNumber { get; set; }
        public string website { get; set; }
        public string adress { get; set; }
        public string BeginWork { get; set; }
        public string EndWork { get; set; }

        private List<Car> productList { get; set; }
        private List<Employee> employees { get; set; }
        private List<Order> orders { get; set; }

        public int CountGoods
        {
            get { return productList.Count; }
        }
        public int CountEmployees
        {
            get { return employees.Count; }
        }

        public int CountOrders
        {
            get { return orders.Count; }
        }

        public Salon()
        {
            productList = new List<Car>();
            employees = new List<Employee>();
            orders = new List<Order>();
        }

        public bool AddProduct(Car new_prod)
        {
            foreach (Car p in productList)
            {
                if (p.product.name == new_prod.product.name)
                    return false;
            }
            productList.Add(new_prod);
            return true;
        }

        public bool DeleteProduct(int index)
        {
            foreach (Car prod in productList)
            {
                if (index == prod.product.id)
                {
                    return productList.Remove(prod);
                }
            }

            return false;
        }

        //Реализовать
        //Метод получения списка для чтения
        public IReadOnlyCollection<Car> GetGoods()
        {
            return productList.AsReadOnly();
        }

        public IReadOnlyCollection<Employee> GetEmployees()
        {
            return employees.AsReadOnly();
        }
        public IReadOnlyCollection<Order> GetOrders()
        {
            return orders.AsReadOnly();
        }

        public bool AddEmployee(Employee new_worker)
        {
            foreach (Employee worker in employees)
            {
                if ((worker.firstName == new_worker.firstName) && (worker.lastName == new_worker.lastName))
                    return false;
            }
            employees.Add(new_worker);
            return true;
        }

        public bool DeleteEmployee(string firstname, string lastname)
        {
            foreach (Employee worker in employees)
            {
                if ((worker.firstName == firstname) && (worker.lastName == lastname))
                {
                    return employees.Remove(worker);
                }
            }

            return false;
        }
        public bool AddOrder(Order new_order)
        {
            foreach (Order order in orders)
            {
                if (order.order_num == new_order.order_num)
                    return false;
            }
            orders.Add(new_order);
            return true;
        }
        public bool DeleteOrder(int number)
        {
            foreach (Order prod in orders)
            {
                if (number == prod.order_num)
                {
                    return orders.Remove(prod);
                }
            }
            return false;
        }
    }
}