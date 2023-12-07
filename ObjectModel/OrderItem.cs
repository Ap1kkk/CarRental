using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   public class OrderItem
    {
       public Car Car { get; set; }
       public int Price { get; set; }

       public OrderItem()
        {
            Car = new Car();
            Car.CarItem.Name = "";
            Car.CarItem.CreationDate = "2000";
            Car.CarItem.Id = 0;
            Car.CarItem.Producer = "";
            Car.CarItem.Price = 0;
            Car.CarItem.StockQuantity = 0;
            Car.CarItem.Description = "";
            Car.Category = "";
        }
    }
}
