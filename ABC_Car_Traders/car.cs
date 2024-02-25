using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class car:product
    {
        public int carId { get; set; }
        public string carMake { get; set; }

        public string carModel { get; set; }
        public int year { get; set; }
        public byte[] ImageData { get; set; }

    }
}
