using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_level_DZ_1_Hryshchenko_Dll;

namespace A_level_DZ_1_Hryshchenko_1
{                                                                    //Закоментированный код - попытки сделать что-то более осмысленное, но увы...)
                                                                     
    class Program
    {
        
        //List<double> dicrim = new List<double>() { };
        //List<double> Lx1 = new List<double>() { };
        //List<double> Lx2 = new List<double>() { };

        public static void Equation()
        {
            int a, b, c;
            Console.Clear();//чистка экрана
            Console.WriteLine("ax^2+bx+c = 0");
            Console.WriteLine("Введите значение 'a': ");
            while (!int.TryParse(Console.ReadLine(), out a))//Проверка ввода
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a");
            }
            

            Console.WriteLine("Введите значение 'b': ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число b");
            }

            Console.WriteLine("Введите значение 'c': ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число c");
            }

            double discr = Calc.Discr(a, b, c);//результат вычисления с Class Library
            //dicrim.Add(discr);
            Console.WriteLine($"Дискриминант: {discr}");
            if (discr > 0)
            {
                double x1 = Calc.FirstX(a, b, c, discr);
                //Lx1.Add(x1);
                Console.WriteLine($"x1: {x1}");

                double x2 = Calc.SecondX(a, b, c, discr);
                //Lx2.Add(x2);
                Console.WriteLine($"x2: {x2}");
                
                Console.WriteLine($"разложение на линейные множители: ({a}x^2)+({b}x)+({c}) = {a}(x - ({x1}))(x - ({x2}))");
            }
            else if (discr == 0)
            {
                double x1 = Calc.FirstX(a, b, c, discr);
                //Lx1.Add(x1);
                Console.WriteLine($"x1: {x1}");
                Console.WriteLine($"разложение на линейные множители: ({a}x^2)+({b}x)+({c}) = {a}(x - ({x1}))");
            }
            else
            {
                Console.WriteLine($"Корней нет!");
            }

            //Console.WriteLine("Разложение на линейные множители: ");
            //int x;
            //double dlinefactor;
            //string linefactor = Calc.LineFactor(a, x1, x2, x);
            Console.ReadKey();
        }

         static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool k = true;
            while (k == true)//для возврата в меню
            {
                


                Console.Clear();
                Console.WriteLine("Данная программа предназначена для поиска корня квадратного трехчлена");
                Console.WriteLine("1 - Найти корень");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Для продолжения введите цифру пункта меню и нажмите Enter: ");

                String menu = Console.ReadLine();
           
                switch (menu)
                {
                    case "1":  Equation();

                        break;
                    //case "2":
                    //    Console.WriteLine(dicrim);
                    //    Console.WriteLine(Lx1);
                    //    Console.WriteLine(Lx2);

                    //    break;
                    case "0":  k=false;
                        break;
                }
            }

        }
    }
}
