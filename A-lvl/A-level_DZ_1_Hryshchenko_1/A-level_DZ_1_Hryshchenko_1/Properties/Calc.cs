using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A_level_DZ_1_Hryshchenko_Dll
{
    public class Calc
    {
        
        //Вычисляем дискриминант
        public static double Discr(int a, int b, int c)
        {
            
            return (b * b) + ((- 4) *( a )*( c));
            //throw new NotImplementedException();
            
        }
        
            //Поиск х1
            public static double FirstX(int a, int b, int c,double discr)
            {
                return((-b)+Math.Sqrt(discr))/(2*a);
            }
            //Поиск х2
            public static double SecondX(int a, int b, int c, double discr)
            {
                return ((-b) - Math.Sqrt(discr)) / (2 * a);
            }

        //Разложение на линейные множители
        //public static string LineFactor(int a, double x1, double x2, int x, double dlinefactor)
        //{

        //   dlinefactor = a * (x - x1) * (x - x2);
        //    string linefactor = string.Parse(dlinefactor);
        //    return linefactor;
        //}
    }
}
