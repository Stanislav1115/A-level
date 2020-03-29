using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FizzBuzzDLL;
using SportDLL;

namespace A_level_DZ_3_Grishchenko
{
    class Program
    {
        static void MSport(double x, double y, int z, int DayX)//Задача номер 2
        {
            Console.Clear();
            Console.WriteLine("Введите колличество километров пройденых спортсменом в первый день (x): ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода! Введите число x: ");
            }
            Console.WriteLine("Введите процент на который будет увеличиваться его пробег (Пример 1,25)  (y): ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите число y: ");
            }
            Console.WriteLine("Введите Z: ");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число z: ");
            }
            DayX = Sport.MetodSport(x, y, z, DayX);
            Console.WriteLine("Результат: ");
            Console.WriteLine(DayX);
            Console.ReadKey();
        }
        static void FizzBuzzVvod( string result, string headresult)//Задача номер 1
        {
            int a = 0;
            int b = 0;
            Console.Clear();
            Console.WriteLine("Введите первое целое число а: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a: ");
            }
            Console.WriteLine("Введите последнее целое число b: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число b: ");
            }

            //FizzBuzz.FizzBuzzMetod(a, b, result);

            Console.WriteLine($"Первое число: {a}");
            Console.WriteLine($"Второе число: {b}");
            headresult = FizzBuzz.FizzBuzzMetod(a, b, result);
            Console.WriteLine("Результат: ");
            Console.WriteLine(headresult);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string result = "";
            string headresult = "";
            double x = 0; 
            double y = 0; 
            int z = 0;
            int DayX = 1;
            while (k == true)
            {



                Console.Clear();
                Console.WriteLine("Выберите задачу: ");
                Console.WriteLine("1 - FizzBuzz");
                Console.WriteLine("2 - Sport");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Для продолжения введите цифру номера задачи и нажмите Enter: ");

                String menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        FizzBuzzVvod(result, headresult);

                        break;
                    case "2":
                        MSport(x, y, z, DayX);

                        break;
                    case "0":
                        k = false;
                        break;
                }
            }

        }
    }
}
