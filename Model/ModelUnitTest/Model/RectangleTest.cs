using System;
using Model;
using NUnit.Framework;

namespace ModelUnitTest.Model
{
    /// <summary>
    /// Юнит-тест площади прямоугольника
    /// </summary>
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        [TestCase(5, 8, TestName = "Тестирование площади при длине = 5, ширине = 8")]
        [TestCase(-1, -7,/*ExpectedException = typeof(FormatException),*/ TestName = "Тестирование площади при длине = -1, ширине = -7")]
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестировние площади при длине = double.MaxValue, ширине = double.MaxValue")]
        [TestCase(double.MinValue, double.MinValue, /*ExpectedException = typeof(FormatException), */
            TestName = "Тестирование площади при длине = double.MinValue, ширине = double.MinValue")]
        [TestCase(double.NaN, double.NaN, TestName = "Тестирование площади при длине = double.NaN, ширине = double.NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity,TestName = "Тестирование площади при длине = -Inf, ширине = -Inf")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity,TestName = "Тестирование площади при длине = +Inf, ширине = +Inf")]
        public void AreaTest(double length, double width)
        {
            var rectangle = new Rectangle(length,width);
            Assert.AreEqual(Math.Round(length * width), 4, rectangle.CalculatedArea);
        }
    }
}