using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Order
    {
        public int order_num { get; set; }
        public int total_price { get; set; }
        public string descr { get; set; }

        public List<OrderLineitem> products;


        public Order()
        {
            products = new List<OrderLineitem>();
        }
        public static bool operator !=(Order left, Order right)
        {
            if (left.order_num != right.order_num)
                return true;
            else return false;
        }
        public static bool operator ==(Order left, Order right)
        {
            if (left.order_num == right.order_num)
                return true;
            else return false;
        }

        public bool AddOrderLineItem(OrderLineitem new_item)
        {
            foreach (OrderLineitem p in products)
            {
                if (p.product == new_item.product)
                    return false;
            }
            products.Add(new_item);
            return true;
        }

        public bool DeleteOrderLineItem(string name)
        {
            foreach (OrderLineitem prod in products)
            {
                if (name == prod.product.product.name)
                {
                    return products.Remove(prod);
                }
            }

            return false;
        }

        public IReadOnlyCollection<OrderLineitem> GetOrdersFields()
        {
            return products.AsReadOnly();
        }
    }
}
