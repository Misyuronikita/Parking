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
            Console.Clear();
        }

        static void Print(CarPlace parking)
        {
            parking.PrintParkedCars();
        }

        static string Input(out string a)
        {
            a = Console.ReadLine();
            Console.Clear();
            return a;
        }

        static void Inicialization(CarPlace parking, DateTime ArrivingTime, string mark, string model, string number, string color)
        {
            parking.ParkCar(new Car
            {
                ArrivingTime = ArrivingTime,
                Mark = mark,
                Model = model,
                Number = number,
                Color = color
            });
        }

        static void Add(CarPlace parking)
        {
            Console.Write("Модель автомобиля: ");
            string model = Input(out model);


            Console.Write("Марка автомобиля: ");
            string mark = Input(out mark);


            Console.Write("Цвет автомобиля: ");
            string color = Input(out color);


            Console.Write("Номер автомобиля: ");
            string number = Input(out number);


            var ArrivingTime = DateTime.Now;

            Inicialization(parking, ArrivingTime, mark, model, number, color);

            Print(parking);
        }

        static void Delete(CarPlace parking)
        {
            Console.WriteLine("Какая машина уехала?");
            int index;
            Check(out index);
            parking.DeleteCar(parking,index);
            Print(parking);
        }

        static void Menu()
        {
            Console.WriteLine("1 - Просмотреть какие машины есть на стоянке\n" +
                "2 - Добавить новую машину\n" +
                "3 - Удалить машину\n" +
                "4 - Выйти из программы");
        }
        static void Exit()
        {
            Environment.Exit(0);
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
                        Mark = "BMW",
                        Model = "X6",
                        Number = "6663 AX-4",
                        Color = "Red",

                    },

                    new Car
                    {
                        ArrivingTime = new DateTime (2022, 08, 18, 13, 48, 34),
                        Mark = "Pegeout",
                        Model = "306",
                        Number = "6564 AB-5",
                        Color = "Black",

                    },
                    new Car
                    {

                        ArrivingTime = new DateTime (2022, 08, 18, 13,56,06),
                        Mark = "Volkswagen",
                        Model = "Polo",
                        Number = "5214 EM-3",
                        Color = "Black",

                    },
                }
            };

            int selection;
            do
            {
                Menu();
                Check(out selection);
                switch (selection)
                {
                    case 1:
                        Print(parking);
                        break;
                    case 2:
                        Add(parking);
                        break;
                    case 3:
                        Delete(parking);
                        break;
                    case 4:
                        Exit();
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

