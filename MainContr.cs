using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class MainContr
    {
        //Список магазинов
        private List<Salon> shops;
        //Делегат событий для обновления
        public delegate void workDone();
        public event workDone update;

        public int CountShop;
        public MainContr()
        {
            ContrDB.Load_from_file();
            shops = new List<Salon>(ContrDB.GetShops());
            CountShop = shops.Count;
        }

        //Метод сохранения БД
        public void Save()
        {
            ContrDB.Save_from_file();
        }

        //Обработчик промежуточных форм
        private void Signal(object sender, EventArgs e)
        {
            shops = new List<Salon>(ContrDB.GetShops());
            update();
        }

        //Метод добавление магазина
        public void AddShop()
        {
            AddSalonForm addShop = new AddSalonForm();
            addShop.FormClosed += Signal;
            addShop.Show();
        }

        //Метод удаления магазина
        public void DeleteShop()
        {
            DeleteSalonForm deleteShop = new DeleteSalonForm();
            deleteShop.FormClosed += Signal;
            deleteShop.Show();
        }

        //Метод получения списка магазинов
        public IReadOnlyList<Salon> GetShop()
        {
            return shops.AsReadOnly();
        }

        public void ProductsInfo(string shop_name)
        {
            foreach (Salon shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                List<Car> products = new List<Car>(shopItem.GetGoods());
                InfoAboutProductsForm ProdInfo = new InfoAboutProductsForm(shop_name, products);
                ProdInfo.FormClosed += Signal;
                ProdInfo.Show();                 
                }
            }
        }

        public void EmployeeInfo(string shop_name)
        {
            foreach (Salon shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                    List<Employee> employees = new List<Employee>(shopItem.GetEmployees());
                    InfoAboutEmployeesForm ProdInfo = new InfoAboutEmployeesForm(shop_name, employees);
                    ProdInfo.FormClosed += Signal;
                    ProdInfo.Show();

                }
            }
        }

        public void OrderInfo(string shop_name)
        {
            foreach (Salon shopItem in shops)
            {
                if (shopItem.name == shop_name)
                {
                    List<Order> orders = new List<Order>(shopItem.GetOrders());
                    InfoAboutOrdersForm ProdInfo = new InfoAboutOrdersForm(shop_name, orders);
                    ProdInfo.FormClosed += Signal;
                    ProdInfo.Show();
                }
            }
        }
    }
}
