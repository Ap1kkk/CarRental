using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   public class Car
    {
        public string category { get; set; }
        public CarItem product { get; set; }

        public Car()
        {
            product = new CarItem();
        }
    }
}
