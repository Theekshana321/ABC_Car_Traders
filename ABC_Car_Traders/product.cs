using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    public abstract class product
    {
        protected product()
        {

        }

        protected product( int quantity, decimal price)
        {
            
            Quantity = quantity;
            Price = price;
            


        }


        
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}

