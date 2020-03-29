using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect
{
    public class Collect
    {
        public static void Col()
        {
            // обобщенная коллекция List
            List<string> genre = new List<string>() { "Комедия", "Боевик", "Драма", "Детектив" };
            foreach (string s in genre)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Хотите добавить элемент? (1 - да, 0 - нет): ");
            int a = 0;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число a: ");
            }
            if (a == 1)
            {
                string element = Console.ReadLine();
                genre.Add(element);
            }
            Console.WriteLine("");
            Console.WriteLine("Хотите удалить элемент? (1 - да, 0 - нет): ");
            a = 0;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число a: ");
            }
            if (a == 1)
            {
                Console.WriteLine("Введите номер элемента для удаления: ");
                int element;
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Ошибка ввода! Введите номер элемента для удаления: ");
                }
                genre.RemoveAt(element); // удаление второго элемента
            }
            foreach (string s in genre)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
