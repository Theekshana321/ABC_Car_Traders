using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class carPart:product
    {
        public int carPartId { get; set; }
        public string partName { get; set; }
        public string description { get; set; }
        public byte[] ImageData { get; set; }

    }
}
