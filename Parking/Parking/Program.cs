using System;
using System.Collections.Generic;


namespace Parking
{
    internal class Program
    {

        static void Menu()
        {
            Console.WriteLine("1 - Просмотреть весь транспорт на стоянке\n" +
                "2 - Просмотреть только машины, которые есть на стоянке\n" +
                "3 - Просмотреть только мотоциклы, которые есть на стоянке\n" +
                "4 - Добавить новую машину\n" +
                "5 - Добавить новый мотоцикл\n" +
                "6 - Удалить машину\n" +
                "7 - Удалить мотоцикл\n" +
                "8 - Выйти из программы");
        }

        static void Check(out int selection)
        {
            while (!int.TryParse(Console.ReadLine(), out selection))
            {
                Console.WriteLine("Ошибка ввода. Попробуйте еще раз!");
            }
            Console.Clear();
        }

        static string Input(out string a)
        {
            a = Console.ReadLine();
            Console.Clear();
            return a;
        }

        static void InicializationCar(CarPlace parking, DateTime ArrivingTime, string mark, string model, string number, string color)
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

        static void InicializationMoto(CarPlace parking, DateTime ArrivingTime, string mark, string model, string number, string color, int year)
        {
            parking.ParkMoto(new Moto
            {
                ArrivingTime = ArrivingTime,
                Mark = mark,
                Model = model,
                Number = number,
                Color = color,
                YearOfIssue = year

            });
        }

        static void PrintAll(CarPlace parking)
        {
            PrintCars(parking);
            PrintMoto(parking);
        }

        static void PrintCars(CarPlace parking)
        {
            parking.PrintParkedCars();
        }

        static void PrintMoto(CarPlace parking)
        {
            parking.PrintParkedMoto();
        }

        static void AddCar(CarPlace parking)
        {
            Console.Write("Марка автомобиля: ");
            string mark = Input(out mark);

            Console.Write("Модель автомобиля: ");
            string model = Input(out model);

            Console.Write("Цвет автомобиля: ");
            string color = Input(out color);


            Console.Write("Номер автомобиля: ");
            string number = Input(out number);

            var ArrivingTime = DateTime.Now;

            InicializationCar(parking, ArrivingTime, mark, model, number, color);

            PrintCars(parking);
        }

        static void AddMoto(CarPlace parking)
        {

            Console.Write("Марка мотоцикла: ");
            string mark = Input(out mark);

            Console.Write("Модель мотоцикла: ");
            string model = Input(out model);

            Console.Write("Цвет мотоцикла: ");
            string color = Input(out color);


            Console.Write("Номер мотоцикла: ");
            string number = Input(out number);

            Console.Write("Год выпуска мотоцикла: ");
            int year; Check(out year);

            var ArrivingTime = DateTime.Now;

            InicializationMoto(parking, ArrivingTime, mark, model, number, color, year);

            PrintMoto(parking);
        }

        static void DeleteCars(CarPlace parking)
        {
            Console.WriteLine("Какая машина уехала?");
            int index;
            Check(out index);
            parking.DeleteCar(index);
            PrintCars(parking);
        }

        static void DeleteMotos(CarPlace parking)
        {
            Console.WriteLine("Какой мотоцикл уехал?");
            int index;
            Check(out index);
            parking.DeleteMoto(index);
            PrintMoto(parking);
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
                        ArrivingTime = new DateTime(2022, 08, 18, 13, 48, 34),
                        Mark = "Pegeout",
                        Model = "306",
                        Number = "6564 AB-5",
                        Color = "Black",

                    },
                    new Car
                    {

                        ArrivingTime = new DateTime(2022, 08, 18, 13, 56, 06),
                        Mark = "Volkswagen",
                        Model = "Polo",
                        Number = "5214 EM-3",
                        Color = "Black",

                    },
                },
                ParkedMotos = new List<Moto>
                {
                    new Moto
                    {
                        ArrivingTime = new DateTime(2022, 08, 21, 12, 41, 06),
                        Mark = "Suzuki",
                        Model = "r600",
                        Number = "4513 HF - 6",
                        Color = "White",
                        YearOfIssue = 2024
                    }
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
                        PrintAll(parking);
                        break;
                    case 2:
                        PrintCars(parking);
                        break;
                    case 3:
                        PrintMoto(parking);
                        break;
                    case 4:
                        AddCar(parking);
                        break;
                    case 5:
                        AddMoto(parking);
                        break;
                    case 6:
                        DeleteCars(parking);
                        break;
                    case 7:
                        DeleteMotos(parking);
                        break;
                    case 8:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Некорректное значение\n");
                        break;
                }
            } while (selection != 8);
            Console.ReadKey();
        }
    }
}

