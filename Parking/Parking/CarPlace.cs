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

        public void ParkMoto(Moto moto)
        {
            ParkedMotos.Add(moto);
        }

        public void DeleteMoto(int indexToRemove)
        {
            ParkedMotos.RemoveAt(indexToRemove);
        }

        public void DeleteCar(int indexToRemove)
        {
            ParkedCars.RemoveAt(indexToRemove);
        }

    }
}
