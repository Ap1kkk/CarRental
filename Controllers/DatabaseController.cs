using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarRental
{
   public class DatabaseController
    {
        static private List<CarSalon> _carSalons = new List<CarSalon>();

        public static void LoadFromFile()
        {
            //Открытие БД
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Выделяем память под список
            _carSalons = new List<CarSalon>();

            //Проходим по списку магазинов в БД
            foreach (XmlNode shopNode in doc.ChildNodes[0].ChildNodes)
            {
                //Выделяем память под магазины
                CarSalon shopItem = new CarSalon();
                //Заполняем данные
                shopItem.Name = shopNode.ChildNodes[0].InnerText;
                shopItem.PhoneNumber = shopNode.ChildNodes[1].InnerText;
                shopItem.Website = shopNode.ChildNodes[2].InnerText;
                shopItem.Adress = shopNode.ChildNodes[3].InnerText;
                shopItem.BeginWork = shopNode.ChildNodes[4].InnerText;
                shopItem.EndWork = shopNode.ChildNodes[5].InnerText;
                //Проходим по привязанному списку товаров
                foreach (XmlNode ProductNode in shopNode.ChildNodes[6].ChildNodes)
                {
                    //Выделяем память под товары
                    Car productItem = new Car();
                    //Заполняем данные
                    productItem.CarItem.Name = ProductNode.ChildNodes[0].InnerText;
                    productItem.CarItem.CreationDate = ProductNode.ChildNodes[1].InnerText;
                    productItem.CarItem.Id = Int32.Parse(ProductNode.ChildNodes[2].InnerText);
                    productItem.CarItem.Producer = ProductNode.ChildNodes[3].InnerText;
                    productItem.CarItem.Price = Int32.Parse(ProductNode.ChildNodes[4].InnerText);
                    productItem.CarItem.StockQuantity = Int32.Parse(ProductNode.ChildNodes[5].InnerText);
                    productItem.CarItem.Description = ProductNode.ChildNodes[6].InnerText;
                    productItem.Category = ProductNode.ChildNodes[7].InnerText;

                   
                    shopItem.AddProduct(productItem);
                }
                foreach (XmlNode EmployeeNode in shopNode.ChildNodes[7].ChildNodes)
                {
                    //Выделяем память под товары
                    Employee employeeItem = new Employee();
                    //Заполняем данные
                    employeeItem.Firstname = EmployeeNode.ChildNodes[0].InnerText;
                    employeeItem.Lastname = EmployeeNode.ChildNodes[1].InnerText;
                    employeeItem.PhoneNumber = EmployeeNode.ChildNodes[2].InnerText;
                    employeeItem.Status = EmployeeNode.ChildNodes[3].InnerText;
                    employeeItem.Experience = EmployeeNode.ChildNodes[4].InnerText;
                    employeeItem.WorkBegin = EmployeeNode.ChildNodes[5].InnerText;
                    employeeItem.WorkEnd = EmployeeNode.ChildNodes[6].InnerText;


                    shopItem.AddEmployee(employeeItem);
                }
                foreach (XmlNode OrderNode in shopNode.ChildNodes[8].ChildNodes)
                {
                    //Выделяем память под товары
                    Order OrderItem = new Order();
                    //Заполняем данные
                    OrderItem.OrderId = Int32.Parse(OrderNode.ChildNodes[0].InnerText);
                    OrderItem.Description = OrderNode.ChildNodes[1].InnerText;
                   foreach(XmlNode OLineNode in OrderNode.ChildNodes[2].ChildNodes)
                    {
                        OrderItem orderLineitem = new OrderItem();
                        orderLineitem.Car.CarItem.Name = OLineNode.ChildNodes[0].InnerText;
                        orderLineitem.Car.CarItem.CreationDate = OLineNode.ChildNodes[1].InnerText;
                        orderLineitem.Car.CarItem.Id = Int32.Parse(OLineNode.ChildNodes[2].InnerText);
                        orderLineitem.Car.CarItem.Producer = OLineNode.ChildNodes[3].InnerText;
                        orderLineitem.Car.CarItem.Price = Int32.Parse(OLineNode.ChildNodes[4].InnerText);
                        orderLineitem.Car.CarItem.StockQuantity = Int32.Parse(OLineNode.ChildNodes[5].InnerText);
                        orderLineitem.Car.CarItem.Description = OLineNode.ChildNodes[6].InnerText;
                        orderLineitem.Car.Category = OLineNode.ChildNodes[7].InnerText;
                        OrderItem.AddOrderItem(orderLineitem);
                    }
                    OrderItem.TotalPrice = Int32.Parse(OrderNode.ChildNodes[3].InnerText);


                    shopItem.AddOrder(OrderItem);
                }
                _carSalons.Add(shopItem);
            }
        }

      
        public static void SaveToFile()
        {
            //Открываем файл для записи
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Очищаем существующую БД для перезаписи
            doc.RemoveAll();
            //Начинаем перезапись
            XmlNode NetNode = doc.CreateElement("Base");
            foreach (CarSalon salon in _carSalons)
            {
                XmlNode SalonNode = doc.CreateElement("Salon");

                XmlNode SalonNameNode = doc.CreateElement("Name");
                SalonNameNode.InnerText = salon.Name;
                SalonNode.AppendChild(SalonNameNode);

                XmlNode PhoneNode = doc.CreateElement("PhoneNumber");
                PhoneNode.InnerText = salon.PhoneNumber;
                SalonNode.AppendChild(PhoneNode);

                XmlNode WebSiteNode = doc.CreateElement("Website");
                WebSiteNode.InnerText = salon.Website;
                SalonNode.AppendChild(WebSiteNode);

                XmlNode AdressNode = doc.CreateElement("Adress");
                AdressNode.InnerText = salon.Adress;
                SalonNode.AppendChild(AdressNode);

                XmlNode StartTimeNode = doc.CreateElement("BeginWork");
                StartTimeNode.InnerText = salon.BeginWork;
                SalonNode.AppendChild(StartTimeNode);

                XmlNode StopTimeNode = doc.CreateElement("EndWork");
                StopTimeNode.InnerText = salon.EndWork;
                SalonNode.AppendChild(StopTimeNode);

                XmlNode CarsNode = doc.CreateElement("Cars");
                XmlNode EmployeesNode = doc.CreateElement("Employees");
                XmlNode OrdersNode = doc.CreateElement("Orders");

                foreach (Car car in salon.GetCars())
                {
                    XmlNode CarNode = doc.CreateElement("Car");

                    XmlNode NameNode = doc.CreateElement("Name");
                    NameNode.InnerText = car.CarItem.Name;
                    CarNode.AppendChild(NameNode);

                    XmlNode CreationDateNode = doc.CreateElement("date_create");
                    CreationDateNode.InnerText = car.CarItem.CreationDate;
                    CarNode.AppendChild(CreationDateNode);

                    XmlNode IndexNode = doc.CreateElement("Index");
                    IndexNode.InnerText = car.CarItem.Id.ToString();
                    CarNode.AppendChild(IndexNode);

                    XmlNode ProducerNode = doc.CreateElement("Producer");
                    ProducerNode.InnerText = car.CarItem.Producer;
                    CarNode.AppendChild(ProducerNode);

                    XmlNode PriceNode = doc.CreateElement("Price");
                    PriceNode.InnerText = car.CarItem.Price.ToString();
                    CarNode.AppendChild(PriceNode);

                    XmlNode StockQuantityNode = doc.CreateElement("StockQuantity");
                    StockQuantityNode.InnerText = car.CarItem.StockQuantity.ToString();
                    CarNode.AppendChild(StockQuantityNode);

                    XmlNode DescriptionNode = doc.CreateElement("params");
                    DescriptionNode.InnerText = car.CarItem.Description;
                    CarNode.AppendChild(DescriptionNode);

                    XmlNode CategoryNode = doc.CreateElement("type");
                    CategoryNode.InnerText = car.Category;
                    CarNode.AppendChild(CategoryNode);

                    CarsNode.AppendChild(CarNode);
                }
                foreach(Employee employee in salon.GetEmployees() )
                {
                    XmlNode EmployeeNode = doc.CreateElement("Employee");

                    XmlNode FnameNode = doc.CreateElement("Firstname");
                    FnameNode.InnerText = employee.Firstname;
                    EmployeeNode.AppendChild(FnameNode);

                    XmlNode LnameNode = doc.CreateElement("Lastname");
                    LnameNode.InnerText = employee.Lastname;
                    EmployeeNode.AppendChild(LnameNode);

                    XmlNode PhoneNumNode = doc.CreateElement("PhoneNumber");
                    PhoneNumNode.InnerText = employee.PhoneNumber;
                    EmployeeNode.AppendChild(PhoneNumNode);

                    XmlNode StatusNode = doc.CreateElement("Status");
                    StatusNode.InnerText = employee.Status;
                    EmployeeNode.AppendChild(StatusNode);

                    XmlNode ExpNode = doc.CreateElement("Experience");
                    ExpNode.InnerText = employee.Experience;
                    EmployeeNode.AppendChild(ExpNode);

                    XmlNode BeginWorkNode = doc.CreateElement("WorkBegin");
                    BeginWorkNode.InnerText = employee.WorkBegin;
                    EmployeeNode.AppendChild(BeginWorkNode);

                    XmlNode EndWorkNode = doc.CreateElement("WorkEnd");
                    EndWorkNode.InnerText = employee.WorkEnd;
                    EmployeeNode.AppendChild(EndWorkNode);

                    EmployeesNode.AppendChild(EmployeeNode);
                }

                foreach(Order order in salon.GetOrders())
                {
                    XmlNode OrderNode = doc.CreateElement("Order");

                    XmlNode IndexNode = doc.CreateElement("Index");
                    IndexNode.InnerText = order.OrderId.ToString();
                    OrderNode.AppendChild(IndexNode);

                    XmlNode DescrNode = doc.CreateElement("Description");
                    DescrNode.InnerText = order.Description;
                    OrderNode.AppendChild(DescrNode);

                    XmlNode OrderItemsNode = doc.CreateElement("OrderItems");

                    foreach (OrderItem orderItem in order.GetOrdersFields())
                    {
                        XmlNode OLineNode = doc.CreateElement("orderLineItem");

                        XmlNode NameNode = doc.CreateElement("Name");
                        NameNode.InnerText = orderItem.Car.CarItem.Name;
                        OLineNode.AppendChild(NameNode);

                        XmlNode DateNode = doc.CreateElement("CreationDate");
                        DateNode.InnerText = orderItem.Car.CarItem.CreationDate;
                        OLineNode.AppendChild(DateNode);

                        XmlNode IndNode = doc.CreateElement("Index");
                        IndNode.InnerText = orderItem.Car.CarItem.Id.ToString();
                        OLineNode.AppendChild(IndNode);

                        XmlNode ProducerNode = doc.CreateElement("Producer");
                        ProducerNode.InnerText = orderItem.Car.CarItem.Producer;
                        OLineNode.AppendChild(ProducerNode);

                        XmlNode CostNode = doc.CreateElement("Price");
                        CostNode.InnerText = orderItem.Car.CarItem.Price.ToString();
                        OLineNode.AppendChild(CostNode);

                        XmlNode CountNode = doc.CreateElement("Quantity");
                        CountNode.InnerText = 1.ToString();
                        OLineNode.AppendChild(CountNode);

                        XmlNode ParamsNode = doc.CreateElement("Description");
                        ParamsNode.InnerText = orderItem.Car.CarItem.Description;
                        OLineNode.AppendChild(ParamsNode);

                        XmlNode TypeNode = doc.CreateElement("Category");
                        TypeNode.InnerText = orderItem.Car.Category;
                        OLineNode.AppendChild(TypeNode);

                        OrderItemsNode.AppendChild(OLineNode);
                    }
                    OrderNode.AppendChild(OrderItemsNode);
                    XmlNode PriceNode = doc.CreateElement("TotalPrice");
                    PriceNode.InnerText = order.TotalPrice.ToString();
                    OrderNode.AppendChild(PriceNode);
                    OrdersNode.AppendChild(OrderNode);

                }
                SalonNode.AppendChild(CarsNode);
                SalonNode.AppendChild(EmployeesNode);
                SalonNode.AppendChild(OrdersNode);
                NetNode.AppendChild(SalonNode);
            }

            doc.AppendChild(NetNode);
            //Сохраняем файл
            doc.Save("DataBase.xml");
        }

        public static void AddSalonDB(CarSalon newSalon)
        {
            SalonController.AddSalon(newSalon, _carSalons);
        }

        public static void DeleteSalonDB(string salonName)
        {
            SalonController.DeleteSalon(salonName, _carSalons);
        }

        public static IReadOnlyCollection<CarSalon> GetSalons()
        {
            return _carSalons.AsReadOnly();
        }

        public static void AddCarDB(string salonName, Car newCar)
        {
            SalonController.AddCar(salonName, newCar, _carSalons);
        }

        public static void DeleteCarDB(string salonName, int index)
        {
            SalonController.DeleteCar(salonName, index, _carSalons);

        }

        public static void AddEmployeeDB(string salonName, Employee newEmployee)
        {
            SalonController.AddEmployee(salonName, newEmployee, _carSalons);
        }

        public static void DeleteEmployeeDB(string salonName, string fname, string lname)
        {
            SalonController.DeleteEmployee(salonName, fname, lname, _carSalons);
        }

        public static void AddOrderDB(string salonName, Order newOrder)
        {
            SalonController.AddOrder(salonName, newOrder, _carSalons);
        }

        public static void DeleteOrderDB(string salonName, int index)
        {
            SalonController.DeleteOrder(salonName, index, _carSalons);
        }
    }
}
