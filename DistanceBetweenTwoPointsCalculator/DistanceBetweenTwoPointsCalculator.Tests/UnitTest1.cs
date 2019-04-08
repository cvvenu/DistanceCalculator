using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceBetweenTwoPointsCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceBetweenTwoPointsWithSameCordinatesShouldReturn0()
        {
            double expectedResault = 0;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoinst2D(1,2,1,2);
            Assert.AreEqual(expectedResault, distance);
        }

        [TestMethod]
        public void DistanceBetweenTwoPointsWithDifferentCordinatesShouldReturnDistance()
        {
            double expectedResault = 5;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoinst2D(2, 5, 5, 9);
            Assert.AreEqual(expectedResault, distance);
        }
    }
}
