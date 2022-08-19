using System;
using System.Collections.Generic;


namespace Parking
{
    internal class Program
    {
        static void Check(out int selection)
        {
            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Error! Try again");
            }
        }
        static void Main(string[] args)
        {
            var parking = new CarPlace
            {
                ParkedCars = new List<Car>
                {
                    new Car
                    {
                        ArrivingTime = new DateTime(2022, 08, 18, 14, 01, 38),
                        mark = "BMW",
                        model = "X6",
                        number = "6663 AX-4",
                        color = "Red",

                    },

                    new Car
                    {
                        ArrivingTime = new DateTime (2022, 08, 18, 13, 48, 34),
                        mark = "Pegeout",
                        model = "306",
                        number = "6564 AB-5",
                        color = "Black",

                    },
                    new Car
                    {

                        ArrivingTime = new DateTime (2022, 08, 18, 13,56,06),
                        mark = "Volkswagen",
                        model = "Polo",
                        number = "5214 EM-3",
                        color = "Black",

                    },
                }
            };


            int selection;
            do
            {
                Console.WriteLine("1 - Просмотреть какие машины есть на стоянке\n" +
                "2 - Добавить новую машину\n" +
                "3 - Удалить машину\n" +
                "4 - Выйти из программы");
               
                Check(out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Parked Cars:\n");
                        parking.PrintParkedCars();
                        break;
                    case 2:
                        Console.Write("Модель автомобиля: ");
                        var model = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Марка автомобиля: ");
                        var mark = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Цвет автомобиля: ");
                        var color = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Номер автомобиля: ");
                        var number = Console.ReadLine();
                        Console.Clear();
                        var ArrivingTime = DateTime.Now;
        
                        parking.ParkCar(new Car
                        {
                            ArrivingTime = ArrivingTime,
                            mark = mark,
                            model = model,
                            number = number,
                            color = color
                        });
                        Console.Clear();
                        
                        parking.PrintParkedCars();
                        break;
                    case 3:
                        Console.WriteLine("Какая машина уехала?");
                        int index;
                        Check(out index);
                        Console.Clear();
                        parking.DeleteCar(parking, index);
                        parking.PrintParkedCars();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректное значение\n");
                        break;
                }
            } while (selection != 4);
            Console.ReadKey();
        }
    }
}

