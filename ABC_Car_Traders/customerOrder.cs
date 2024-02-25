using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class customerOrder
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public customerOrder(int orderId, int customerId, int itemId, DateTime orderDate, int quantity, decimal totalPrice)
        {
            OrderId = orderId;
            CustomerId = customerId;
            ItemId =itemId;
            OrderDate = orderDate;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
