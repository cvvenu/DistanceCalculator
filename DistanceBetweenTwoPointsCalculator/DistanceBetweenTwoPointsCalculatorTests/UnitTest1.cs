using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceBetweenTwoPointsCalculatorTests
{
    [TestClass]
    public class DistanceCalculatorHelperTests
    {
        [TestMethod]
        public void TwoPointsWithTheSameCordinatesShouldReturn0()
        {
            double expectedResault = 0;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoinst2D(1, 1, 1, 1);
            
        }
    }
}
