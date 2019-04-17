using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPointsCalculator
{
    internal static class DistanceCalculatorHelper
    {
        static internal double DistanceBetweenTwoPoinst2D(double x1, double y1, double x2, double y2)
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }

        static internal double ParseToDoubleInputValue()
        {
            Boolean areValueDouble = false;
            double value = 0;
            while(areValueDouble == false)
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    areValueDouble = true;
                    
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("To jest współrzędna punktu, należy podać liczbę");
                }

            }
            return value;
        }

    }
}
