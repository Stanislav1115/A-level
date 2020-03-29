using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collect;

namespace Collections
{
    public class Program
    {

        static void Matrr()
        {
            int n;
            Console.Clear();
            Console.WriteLine("Введите колличество строк и столбцов квадратной матрицы: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите число N: ");
            }
            int[,] matrica = new int[n,n] ;
            Random random = new Random();
            int rand;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rand = random.Next(0, 100);
                    matrica[i, j] = rand;
                }
            }
            Console.WriteLine("Исходная матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] newmatr = new int[n, n];
            Console.WriteLine("Транспонированная матрица: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    newmatr[i, j] = matrica[j, i];
                    Console.Write(newmatr[i, j] + " \t ");

                    if (j == n - 1)
                        Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        static void Coll()
        {
            Collect.Collect.Col();
        }
        


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string result = "";
            string headresult = "";
            double x = 0;
            double y = 0;
            int z = 0;
            
            
            bool k = true;
            while (k == true)
            {



                Console.Clear();
                Console.WriteLine("_________________________________________________________________________");
                Console.WriteLine("|Выберите задачу:                                                       |");
                Console.WriteLine("|1 - Матрицы                                                            |");
                Console.WriteLine("|2 - Коллекции                                                          |");
                Console.WriteLine("|0 - Exit                                                               |");
                Console.WriteLine("|Для продолжения введите цифру и нажмите Enter:                         |");
                Console.WriteLine("|_______________________________________________________________________|");

                String menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":  Matrr();
                        break;

                    case "2":  Coll();
                        break;
                    case "0":
                        k = false;
                        break;
                }
            }

        }
    }
}
