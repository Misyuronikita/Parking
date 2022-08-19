using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    internal class CarPlace: Car
    {
        public List<Car> ParkedCars { get; set; }
        public void PrintParkedCars()
        {
            ParkedCars.ForEach(p =>
            Console.WriteLine($"Model: {p.model}\n" +
            $"Mark: {p.mark}\n" +
            $"Color: {p.color}\n" +
            $"Number: {p.number}\n" +
            $"Arriving time: {p.ArrivingTime.ToShortTimeString()}\n\n\n")
            );
        }
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
