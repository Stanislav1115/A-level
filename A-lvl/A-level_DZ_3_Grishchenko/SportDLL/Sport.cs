using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportDLL
{
    public class Sport
    {
        public static int MetodSport(double x, double y, int  z, int DayX)
        {
            int k = 2;
            for (double i = x; i < z; i = (i + 0))
            {
                if (k == 1)
                {
                    i = (i * y);
                    k = 2;
                    DayX += 1; 
                }
                else 
                {
                    k = 1;
                    DayX += 1;
                }
            }
            return DayX;
        }
    }
}
