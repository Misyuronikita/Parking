using System;
using System.Collections.Generic;

namespace Parking
{
    internal class CarPlacePrinter
    {
        static string CheckNullOrEmpty(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                s = "Не указано";
                return s;
            }
            else
            {
                return s;
            }
        }

        static string Year(int year)
        {
            if (year < 2022 && year > 1920)
            {
                return Convert.ToString(year);
            }
            else
            {
                return "Не верно указан год выпуска";
            }
        }

        public List<Car> ParkedCars { get; set; }
        public void PrintParkedCars()
        {
            ParkedCars.ForEach(p =>
            Console.WriteLine($"Mark: {CheckNullOrEmpty(p.Mark)}\n" +
            $"Model: {CheckNullOrEmpty(p.Model)}\n" +
            $"Color: {CheckNullOrEmpty(p.Color)}\n" +
            $"Number: {CheckNullOrEmpty(p.Number)}\n" +
            $"Arriving time: {p.ArrivingTime.ToShortTimeString()}\n\n\n")
            );
        }
        
        public List<Moto> ParkedMotos { get; set; }
        public void PrintParkedMoto()
        {
            ParkedMotos.ForEach(q =>
            Console.WriteLine($"Mark: {CheckNullOrEmpty(q.Mark)}\n" +
            $"Model: {CheckNullOrEmpty(q.Model)}\n" +
            $"Color: {CheckNullOrEmpty(q.Color)}\n" +
            $"Number: {CheckNullOrEmpty(q.Number)}\n" +
            $"Year of Issue: {Year(q.YearOfIssue)}\n" +
            $"Arriving time: {q.ArrivingTime.ToShortTimeString()}\n\n\n")
            );
        }
    }
}
