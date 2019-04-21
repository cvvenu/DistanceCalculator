using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPointsCalculator
{
    internal static class DistanceCalculatorHelper
    {
        static internal double DistanceBetweenTwoPoints2D(double x1, double y1, double x2, double y2)
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }

        static internal double DistanceBetweenTwoPoints3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double temp1 = Math.Pow((x1 - x2), 2);
            double temp2 = Math.Pow((y1 - y2), 2);
            double temp3 = Math.Pow((z1 - z2), 2);
            double result = Math.Sqrt(temp1 + temp2 + temp3);
            return result;
        }

        static internal double ParseToDoubleInputValue(String tryToParse)
        {
            Boolean areValueDouble = false;
            double value = 0;
            while(areValueDouble == false)
            {
                try
                {
                    value = Convert.ToDouble(tryToParse);
                    areValueDouble = true;                   
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("To jest współrzędna punktu, należy podać liczbę");
                    tryToParse = Console.ReadLine();
                }
            }
            return value;
        }
    }
}
