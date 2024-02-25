using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class Bill
    {
        public int BillID { get; set; }
        public int OrderID { get; set;}
        public DateTime PaymentDate { get; set;}
        public int CustomerID { get; set; }
        public decimal Amount { get; set; }
        
        public int Quantity { get; set; }

    }
}
