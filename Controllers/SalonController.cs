using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class SalonController
    {
        public delegate void workDone();
        public event workDone OnUpdate;

        public static bool AddSalon(CarSalon carSalon, List<CarSalon> salons)
        {
            foreach (CarSalon salon in salons)
            {
                if (salon.Name == salon.Name)
                    return false;
            }
            salons.Add(carSalon);
            return true;
        }

        public static void DeleteSalon(string salonName, List<CarSalon> salons)
        {
            foreach (CarSalon salon in salons)
            {
                if (salon.Name == salonName)
                {
                    salons.Remove(salon);
                    break;
                }
            }
        }

        public static bool AddCar(string salonName, Car newCar, List<CarSalon> salons)
        {
            foreach (CarSalon salon in salons)
            {
                if (salon.Name == salonName)
                {
                    return salon.AddProduct(newCar);
                }
            }
            return false;
        }

        public static void DeleteCar(string salonName, int index, List<CarSalon> salons)
        {
            foreach (CarSalon salon in salons)
            {
                if (salon.Name == salonName)
                {
                    salon.DeleteProduct(index);
                    break;
                }
            }
        }

        public static bool AddEmployee(string salonName, Employee _new_prod, List<CarSalon> salons)
        {
            foreach (CarSalon s in salons)
            {
                if (s.Name == salonName)
                {
                    return s.AddEmployee(_new_prod);
                }
            }
            return false;
        }

        public static void DeleteEmployee(string salonName, string fname, string lname, List<CarSalon> salons)
        {
            foreach (CarSalon shop in salons)
            {
                if (shop.Name == salonName)
                {
                    shop.DeleteEmployee(fname, lname);
                    break;
                }
            }
        }

        public static bool AddOrder(string salonName, Order newOrder, List<CarSalon> salons)
        {
            foreach (CarSalon s in salons)
            {
                if (s.Name == salonName)
                {
                    return s.AddOrder(newOrder);
                }
            }
            return false;
        }

        public static void DeleteOrder(string salonName, int index, List<CarSalon> salons)
        {
            foreach (CarSalon shop in salons)
            {
                if (shop.Name == salonName)
                {
                    shop.DeleteOrder(index);
                    break;
                }
            }
        }
    }
}
