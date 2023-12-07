using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TotalPrice { get; set; }
        public string Description { get; set; }

        public List<OrderItem> _products;

        public Order()
        {
            _products = new List<OrderItem>();
        }

        public static bool operator !=(Order left, Order right)
        {
            if (left.OrderId != right.OrderId)
                return true;
            else return false;
        }
        public static bool operator ==(Order left, Order right)
        {
            if (left.OrderId == right.OrderId)
                return true;
            else return false;
        }

        public bool AddOrderItem(OrderItem newOrderItem)
        {
            foreach (OrderItem orderItem in _products)
            {
                if (orderItem.Car == newOrderItem.Car)
                    return false;
            }
            _products.Add(newOrderItem);
            return true;
        }

        public bool DeleteOrderItem(string name)
        {
            foreach (OrderItem orderItem in _products)
            {
                if (name == orderItem.Car.CarItem.Name)
                {
                    return _products.Remove(orderItem);
                }
            }
            return false;
        }

        public IReadOnlyCollection<OrderItem> GetOrdersFields()
        {
            return _products.AsReadOnly();
        }
    }
}
