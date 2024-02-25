using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    internal class cart
    {
        private List<int> carIds;

        public cart()
        {
            carIds = new List<int>();
        }

        public void AddCar(int carId)
        {
            carIds.Add(carId);
        }

        public void RemoveCar(int carId)
        {
            carIds.Remove(carId);
        }

        public List<int> GetCarIds()
        {
            return carIds;
        }


        public void ClearCart()
        {
            carIds.Clear();
        }
    }
}
