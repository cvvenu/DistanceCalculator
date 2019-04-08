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
            Console.WriteLine("Podaj współrzędne punktu pierwszego:");
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędne punktu drugiego:");
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distanceBetweenTwoPoints2D = DistanceCalculatorHelper.DistanceBetweenTwoPoinst2D(x1, y1, x2, y2);
            Console.WriteLine("Odległość pomiędzy punktami wynosi: " + distanceBetweenTwoPoints2D);

            Console.ReadKey();
        }
    }
}
