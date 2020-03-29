using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDLL
{
    public class FizzBuzz
    {
        public static string FizzBuzzMetod(int a, int b, string result)
        {
            int mnozhitel = 0;
            for (int i = a; i < (b + 1); i++)
            {

                if (i == 3 && i != 5 && i != 7)
                {
                    Console.WriteLine("Введите простой множитель <<3>>: ");
                    while ((mnozhitel = int.Parse(Console.ReadLine())) != 3)
                    {
                        Console.WriteLine("Ошибка! Введите простой множитель <<3>>: ");
                    }
                    result += ($"({mnozhitel} Fizz) ");
                }
                else if (i == 5 && i != 3 && i != 7)
                {
                    Console.WriteLine("Введите простой множитель <<5>>: ");
                    while (((mnozhitel = int.Parse(Console.ReadLine())) != 5))
                    {
                        Console.WriteLine("Ошибка! Введите простой множитель <<5>>: ");
                    }
                    result += ($"({mnozhitel} Buzz) ");
                }
                else if (i == 7 && i != 3 && i != 5)
                {
                    Console.WriteLine("Введите простой множитель <<7>>: ");
                    while (((mnozhitel = int.Parse(Console.ReadLine())) != 7))
                    {
                        Console.WriteLine("Ошибка! Введите простой множитель <<7>>: ");
                    }
                    result += ($"({mnozhitel}) ");

                }
                else if ((i % 5) == 0 && (i % 3) == 0 && i!=3 && i!=5 && i!=7)
                {
                    result += "FizzBuzz ";
                }
                else if ((i % 3) == 0 && i != 3 && i != 5 && i != 7)
                {
                    
                    
                    
                    result += "Fizz ";
                    
                }
                else if ((i % 5) == 0 && i != 3 && i != 5 && i != 7)
                {
                    
                    
                     result += "Buzz ";
                    
                }
                else 
                {
                    result += i+" ";
                }
            }

            return result; 
        }
    }
}
