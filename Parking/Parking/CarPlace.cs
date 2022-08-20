using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    internal class CarPlace: CarPlacePrinter
    {
        
        public void ParkCar(Car car)
        {
            ParkedCars.Add(car);
        }

        public void DeleteCar(Car car, int indexToRemove)
        {
            ParkedCars.RemoveAt(indexToRemove);
        }

    }
}
