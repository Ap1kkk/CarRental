using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarRental
{
   public class ContrDB
    {
        static private List<Salon> shops = new List<Salon>();

        public static void Load_from_file()
        {
            //Открытие БД
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Выделяем память под список
            shops = new List<Salon>();

            //Проходим по списку магазинов в БД
            foreach (XmlNode shopNode in doc.ChildNodes[0].ChildNodes)
            {
                //Выделяем память под магазины
                Salon shopItem = new Salon();
                //Заполняем данные
                shopItem.name = shopNode.ChildNodes[0].InnerText;
                shopItem.PhoneNumber = shopNode.ChildNodes[1].InnerText;
                shopItem.website = shopNode.ChildNodes[2].InnerText;
                shopItem.adress = shopNode.ChildNodes[3].InnerText;
                shopItem.BeginWork = shopNode.ChildNodes[4].InnerText;
                shopItem.EndWork = shopNode.ChildNodes[5].InnerText;
                //Проходим по привязанному списку товаров
                foreach (XmlNode ProductNode in shopNode.ChildNodes[6].ChildNodes)
                {
                    //Выделяем память под товары
                    Car productItem = new Car();
                    //Заполняем данные
                    productItem.product.name = ProductNode.ChildNodes[0].InnerText;
                    productItem.product.date_create = ProductNode.ChildNodes[1].InnerText;
                    productItem.product.id = Int32.Parse(ProductNode.ChildNodes[2].InnerText);
                    productItem.product.producer = ProductNode.ChildNodes[3].InnerText;
                    productItem.product.price = Int32.Parse(ProductNode.ChildNodes[4].InnerText);
                    productItem.product.count = Int32.Parse(ProductNode.ChildNodes[5].InnerText);
                    productItem.product.description = ProductNode.ChildNodes[6].InnerText;
                    productItem.category = ProductNode.ChildNodes[7].InnerText;

                   
                    shopItem.AddProduct(productItem);
                }
                foreach (XmlNode EmployeeNode in shopNode.ChildNodes[7].ChildNodes)
                {
                    //Выделяем память под товары
                    Employee employeeItem = new Employee();
                    //Заполняем данные
                    employeeItem.firstName = EmployeeNode.ChildNodes[0].InnerText;
                    employeeItem.lastName = EmployeeNode.ChildNodes[1].InnerText;
                    employeeItem.PhoneNumber = EmployeeNode.ChildNodes[2].InnerText;
                    employeeItem.status = EmployeeNode.ChildNodes[3].InnerText;
                    employeeItem.experience = EmployeeNode.ChildNodes[4].InnerText;
                    employeeItem.workBegin = EmployeeNode.ChildNodes[5].InnerText;
                    employeeItem.workEnd = EmployeeNode.ChildNodes[6].InnerText;


                    shopItem.AddEmployee(employeeItem);
                }
                foreach (XmlNode OrderNode in shopNode.ChildNodes[8].ChildNodes)
                {
                    //Выделяем память под товары
                    Order OrderItem = new Order();
                    //Заполняем данные
                    OrderItem.order_num = Int32.Parse(OrderNode.ChildNodes[0].InnerText);
                    OrderItem.descr = OrderNode.ChildNodes[1].InnerText;
                   foreach(XmlNode OLineNode in OrderNode.ChildNodes[2].ChildNodes)
                    {
                        OrderLineitem orderLineitem = new OrderLineitem();
                        orderLineitem.product.product.name = OLineNode.ChildNodes[0].InnerText;
                        orderLineitem.product.product.date_create = OLineNode.ChildNodes[1].InnerText;
                        orderLineitem.product.product.id = Int32.Parse(OLineNode.ChildNodes[2].InnerText);
                        orderLineitem.product.product.producer = OLineNode.ChildNodes[3].InnerText;
                        orderLineitem.product.product.price = Int32.Parse(OLineNode.ChildNodes[4].InnerText);
                        orderLineitem.product.product.count = Int32.Parse(OLineNode.ChildNodes[5].InnerText);
                        orderLineitem.product.product.description = OLineNode.ChildNodes[6].InnerText;
                        orderLineitem.product.category = OLineNode.ChildNodes[7].InnerText;
                        OrderItem.AddOrderLineItem(orderLineitem);
                    }
                    OrderItem.total_price = Int32.Parse(OrderNode.ChildNodes[3].InnerText);


                    shopItem.AddOrder(OrderItem);
                }
                shops.Add(shopItem);
            }
        }

      
        public static void Save_from_file()
        {
            //Открываем файл для записи
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Очищаем существующую БД для перезаписи
            doc.RemoveAll();
            //Начинаем перезапись
            XmlNode NetNode = doc.CreateElement("Base");
            foreach (Salon shop in shops)
            {
                XmlNode ShopNode = doc.CreateElement("shop");

                XmlNode ShopNameNode = doc.CreateElement("name");
                ShopNameNode.InnerText = shop.name;
                ShopNode.AppendChild(ShopNameNode);

                XmlNode PhoneNode = doc.CreateElement("PhoneNumber");
                PhoneNode.InnerText = shop.PhoneNumber;
                ShopNode.AppendChild(PhoneNode);

                XmlNode WebSiteNode = doc.CreateElement("website");
                WebSiteNode.InnerText = shop.website;
                ShopNode.AppendChild(WebSiteNode);

                XmlNode AdressNode = doc.CreateElement("adress");
                AdressNode.InnerText = shop.adress;
                ShopNode.AppendChild(AdressNode);

                XmlNode StartTimeNode = doc.CreateElement("BeginWork");
                StartTimeNode.InnerText = shop.BeginWork;
                ShopNode.AppendChild(StartTimeNode);

                XmlNode StopTimeNode = doc.CreateElement("EndWork");
                StopTimeNode.InnerText = shop.EndWork;
                ShopNode.AppendChild(StopTimeNode);

                XmlNode GoodsNode = doc.CreateElement("products");
                XmlNode EmployeesNode = doc.CreateElement("employees");
                XmlNode OrdersNode = doc.CreateElement("orders");

                foreach (Car prod in shop.GetGoods())
                {
                    XmlNode ProductNode = doc.CreateElement("product");

                    XmlNode NameNode = doc.CreateElement("name");
                    NameNode.InnerText = prod.product.name;
                    ProductNode.AppendChild(NameNode);

                    XmlNode DateNode = doc.CreateElement("date_create");
                    DateNode.InnerText = prod.product.date_create;
                    ProductNode.AppendChild(DateNode);

                    XmlNode IndexNode = doc.CreateElement("index");
                    IndexNode.InnerText = prod.product.id.ToString();
                    ProductNode.AppendChild(IndexNode);

                    XmlNode ProducerNode = doc.CreateElement("producer");
                    ProducerNode.InnerText = prod.product.producer;
                    ProductNode.AppendChild(ProducerNode);

                    XmlNode PriceNode = doc.CreateElement("price");
                    PriceNode.InnerText = prod.product.price.ToString();
                    ProductNode.AppendChild(PriceNode);

                    XmlNode CountNode = doc.CreateElement("count");
                    CountNode.InnerText = prod.product.count.ToString();
                    ProductNode.AppendChild(CountNode);

                    XmlNode ParamsNode = doc.CreateElement("params");
                    ParamsNode.InnerText = prod.product.description;
                    ProductNode.AppendChild(ParamsNode);

                    XmlNode TypeNode = doc.CreateElement("type");
                    TypeNode.InnerText = prod.category;
                    ProductNode.AppendChild(TypeNode);

                    GoodsNode.AppendChild(ProductNode);
                }
                foreach(Employee employer in shop.GetEmployees() )
                {
                    XmlNode EmployerNode = doc.CreateElement("employer");

                    XmlNode FnameNode = doc.CreateElement("firstName");
                    FnameNode.InnerText = employer.firstName;
                    EmployerNode.AppendChild(FnameNode);

                    XmlNode LnameNode = doc.CreateElement("lastName");
                    LnameNode.InnerText = employer.lastName;
                    EmployerNode.AppendChild(LnameNode);

                    XmlNode PhoneNumNode = doc.CreateElement("PhoneNumber");
                    PhoneNumNode.InnerText = employer.PhoneNumber;
                    EmployerNode.AppendChild(PhoneNumNode);

                    XmlNode StatusNode = doc.CreateElement("status");
                    StatusNode.InnerText = employer.status;
                    EmployerNode.AppendChild(StatusNode);

                    XmlNode ExpNode = doc.CreateElement("experience");
                    ExpNode.InnerText = employer.experience;
                    EmployerNode.AppendChild(ExpNode);

                    XmlNode BeginWorkNode = doc.CreateElement("workBegin");
                    BeginWorkNode.InnerText = employer.workBegin;
                    EmployerNode.AppendChild(BeginWorkNode);

                    XmlNode EndWorkNode = doc.CreateElement("workEnd");
                    EndWorkNode.InnerText = employer.workEnd;
                    EmployerNode.AppendChild(EndWorkNode);

                    EmployeesNode.AppendChild(EmployerNode);
                }

                foreach(Order order in shop.GetOrders())
                {
                    XmlNode OrderNode = doc.CreateElement("order");

                    XmlNode IndexNode = doc.CreateElement("index");
                    IndexNode.InnerText = order.order_num.ToString();
                    OrderNode.AppendChild(IndexNode);

                    XmlNode DescrNode = doc.CreateElement("descr");
                    DescrNode.InnerText = order.descr;
                    OrderNode.AppendChild(DescrNode);

                    XmlNode OrderItemsNode = doc.CreateElement("orderLineItems");

                    foreach (OrderLineitem order_field in order.GetOrdersFields())
                    {
                        XmlNode OLineNode = doc.CreateElement("orderLineItem");

                        XmlNode NameNode = doc.CreateElement("name");
                        NameNode.InnerText = order_field.product.product.name;
                        OLineNode.AppendChild(NameNode);

                        XmlNode DateNode = doc.CreateElement("date_create");
                        DateNode.InnerText = order_field.product.product.date_create;
                        OLineNode.AppendChild(DateNode);

                        XmlNode IndNode = doc.CreateElement("index");
                        IndNode.InnerText = order_field.product.product.id.ToString();
                        OLineNode.AppendChild(IndNode);

                        XmlNode ProducerNode = doc.CreateElement("producer");
                        ProducerNode.InnerText = order_field.product.product.producer;
                        OLineNode.AppendChild(ProducerNode);

                        XmlNode CostNode = doc.CreateElement("price");
                        CostNode.InnerText = order_field.product.product.price.ToString();
                        OLineNode.AppendChild(CostNode);

                        XmlNode CountNode = doc.CreateElement("count");
                        CountNode.InnerText = 1.ToString();
                        OLineNode.AppendChild(CountNode);

                        XmlNode ParamsNode = doc.CreateElement("params");
                        ParamsNode.InnerText = order_field.product.product.description;
                        OLineNode.AppendChild(ParamsNode);

                        XmlNode TypeNode = doc.CreateElement("type");
                        TypeNode.InnerText = order_field.product.category;
                        OLineNode.AppendChild(TypeNode);

                        OrderItemsNode.AppendChild(OLineNode);
                    }
                    OrderNode.AppendChild(OrderItemsNode);
                    XmlNode PriceNode = doc.CreateElement("totalPrice");
                    PriceNode.InnerText = order.total_price.ToString();
                    OrderNode.AppendChild(PriceNode);
                    OrdersNode.AppendChild(OrderNode);

                }
                ShopNode.AppendChild(GoodsNode);
                ShopNode.AppendChild(EmployeesNode);
                ShopNode.AppendChild(OrdersNode);
                NetNode.AppendChild(ShopNode);
            }

            doc.AppendChild(NetNode);
            //Сохраняем файл
            doc.Save("DataBase.xml");
        }

        public static void AddShopDB(Salon new_shop)
        {
            SalonContr.AddShop(new_shop, shops);
        }

        public static void DeleteShopDB(string shop_del)
        {
            SalonContr.DeleteShop(shop_del, shops);
        }

        //Метод получения списка Магазинов
        public static IReadOnlyCollection<Salon> GetShops()
        {
            return shops.AsReadOnly();
        }

        //Метод добавления товара
        public static void AddProductDB(string _shop_name, Car _new_prod)
        {
            SalonContr.AddProduct(_shop_name, _new_prod, shops);
        }

        //Метод удаления товара
        public static void DeleteProductDB(string _shop_name, int indx)
        {
            SalonContr.DeleteProduct(_shop_name, indx, shops);

        }

        //Метод добавления сторудника
        public static void AddEmployeeDB(string _shop_name, Employee _new_prod)
        {
            SalonContr.AddEmployee(_shop_name, _new_prod, shops);
        }

        //Метод удаления сотрудника
        public static void DeleteEmployeeDB(string _shop_name, string fname, string lname)
        {
            SalonContr.DeleteEmployee(_shop_name, fname, lname, shops);
        }

        public static void AddOrderDB(string _shop_name, Order _new_order)
        {
            SalonContr.AddOrder(_shop_name, _new_order, shops);
        }

        public static void DeleteOrderDB(string _shop_name, int i)
        {
            SalonContr.DeleteOrder(_shop_name, i, shops);
        }
    }
}
