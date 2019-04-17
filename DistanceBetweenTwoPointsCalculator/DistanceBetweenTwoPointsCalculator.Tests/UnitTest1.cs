using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DistanceBetweenTwoPointsCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DistanceBetweenTwoPoints2DWithSameCordinatesShouldReturn0()
        {
            double expectedResault = 0;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoints2D(1,2,1,2);
            Assert.AreEqual(expectedResault, distance);
        }

        [TestMethod]
        public void DistanceBetweenTwoPoints2DWithDifferentCordinatesShouldReturnDistance()
        {
            double expectedResault = 5;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoints2D(2, 5, 5, 9);
            Assert.AreEqual(expectedResault, distance);
        }

        [TestMethod]
        public void DistanceBetweenTwoPoints3DWithDifferentCordinatesShouldReturn0()
        {
            double expectedResault = 0;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoints3D(1,2,3,1,2,3);
            Assert.AreEqual(expectedResault, distance);
        }

        [TestMethod]
        public void DistanceBetweenTwoPoints3DWithDifferentCordinatesShouldReturnDistance()
        {
            double expectedResault = 1;
            double distance = DistanceCalculatorHelper.DistanceBetweenTwoPoints3D(0,0,0, 0, 0, 1);
            Assert.AreEqual(expectedResault, distance);
        }

        //[TestMethod]
        //[ExpectedException(typeof(FormatException))]
        //public void ParsingStringToDoubleShouldReturnException()
        //{
        //    var a = 's';
        //    DistanceCalculatorHelper.ParseToDoubleInputValue();

        //}
    }
}
