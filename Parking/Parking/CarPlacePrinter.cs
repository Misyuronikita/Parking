using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    internal class CarPlacePrinter: Car
    {
        public List<Car> ParkedCars { get; set; }
        public void PrintParkedCars()
        {
            ParkedCars.ForEach(p =>
            Console.WriteLine($"Model: {p.Model}\n" +
            $"Mark: {p.Mark}\n" +
            $"Color: {p.Color}\n" +
            $"Number: {p.Number}\n" +
            $"Arriving time: {p.ArrivingTime.ToShortTimeString()}\n\n\n")
            );
        }

    }
}
