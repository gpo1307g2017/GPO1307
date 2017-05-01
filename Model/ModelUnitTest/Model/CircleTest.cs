using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using NUnit.Framework;
using System;

namespace ModelUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        [TestCase(5, TestName = "Тестирование площади при радиусе = 5.")]
        [TestCase(-1, TestName = "Тестирование площади при радиусе = -1")]
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            NUnit.Framework.Assert.AreEqual(Math.PI * Math.Pow(radius, 2), circle.CalculatedArea);
        }

    }
}
