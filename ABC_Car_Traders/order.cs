using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
