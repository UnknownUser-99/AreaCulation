using System;
using AreaСalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestAreaCalculation
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.54, circle.CalculateArea(), 0.01);
        }

        [TestMethod]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 0.01);
        }

        [TestMethod]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}
