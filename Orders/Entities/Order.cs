using Orders.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) 
        { 
            Items.Remove(item); 
        }

        public void Clear()
        {
            Items.Clear();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.GetSubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
