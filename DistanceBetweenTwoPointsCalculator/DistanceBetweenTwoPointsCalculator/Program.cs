using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPointsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
            Console.Write("y1 = ");
            double y1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
            Console.Write("x2 = ");
            double x2 = DistanceCalculatorHelper.ParseToDoubleInputValue();
            Console.Write("y2 = ");
            double y2 = DistanceCalculatorHelper.ParseToDoubleInputValue();

            double distanceBetweenTwoPoints2D = DistanceCalculatorHelper.DistanceBetweenTwoPoinst2D(x1, y1, x2, y2);
            Console.WriteLine("Odległość pomiędzy punktami wynosi: " + distanceBetweenTwoPoints2D);

            Console.ReadKey();
        }
    }
}
