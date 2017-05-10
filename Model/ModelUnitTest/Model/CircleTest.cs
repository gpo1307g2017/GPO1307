using NUnit.Framework;
using Model;
using System;

namespace ModelUnitTest.Model
{
    /// <summary>
    /// Юнит-тест площади круга
    /// </summary>
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(5, TestName = "Тестирование площади при радиусе = 5.")]

        [TestCase(-1, ExpectedException = typeof(FormatException), TestName =
            "Тестирование площади при радиусе = -1")]

        [TestCase(double.MaxValue, TestName = "Тестировние площади при радиусе =  Double MaxValue")]

        [TestCase(double.MinValue, ExpectedException = typeof(FormatException), TestName =
            "Тестирование площади при радиусе = double MinValue")]

        [TestCase(double.NaN,ExpectedException  = typeof(NotFiniteNumberException), TestName = "Тестирование площади при радиусе = NaN")]

        [TestCase(double.NegativeInfinity, ExpectedException = typeof(FormatException),
            TestName = "Тестирование площади при радиусе = -Inf")]

        [TestCase(double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при радиусе = +Inf")]

        // Тестоывй метод проверки площади круга
        // Передаётся radius-радиус круга,
        public void AreaTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.AreEqual(Math.Round((Math.Pow(radius, 2) * Math.PI), 4), circle.CalculatedArea);

        }

    }
}
