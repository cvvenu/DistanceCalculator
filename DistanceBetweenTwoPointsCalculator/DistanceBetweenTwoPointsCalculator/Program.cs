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
            double x1, x2, y1, y2, z1, z2;


            Console.WriteLine("Kalkulator odległości między punktami");
            Console.WriteLine("Chcesz obliczyc odległość między punktami w: ");
            Console.WriteLine("a) 2d?");
            Console.WriteLine("b) 3d?");
            var plain = Console.ReadLine();
            
            switch(plain)
            {
                case "a":
                    Console.Write("x1 = ");
                    x1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("y1 = ");
                    y1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("x2 = ");
                    x2 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("y2 = ");
                    y2 = DistanceCalculatorHelper.ParseToDoubleInputValue();

                    double distanceBetweenTwoPoints2D = DistanceCalculatorHelper.DistanceBetweenTwoPoints2D(x1, y1, x2, y2);
                    Console.WriteLine("Odległość pomiędzy punktami wynosi: " + distanceBetweenTwoPoints2D);
                    break;

                case "b":
                    Console.Write("x1 = ");
                    x1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("y1 = ");
                    y1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("z1 = ");
                    z1 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("x2 = ");
                    x2 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("y2 = ");
                    y2 = DistanceCalculatorHelper.ParseToDoubleInputValue();
                    Console.Write("z2 = ");
                    z2 = DistanceCalculatorHelper.ParseToDoubleInputValue();

                    double distanceBetweenTwoPoints3D = DistanceCalculatorHelper.DistanceBetweenTwoPoints3D(x1, y1, z1, x2, y2, z2);
                    Console.WriteLine("Odległość pomiędzy punktami wynosi: " + distanceBetweenTwoPoints3D);
                    break;
            }
            Console.ReadKey();




        }
    }
}
