using System;
using Model;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ModelUnitTest.Model
{
    /// <summary>
    /// Юнит-тест площади триугольника
    /// </summary>
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(5, 8, TestName = "Тестирование площади при основании = 5, высоте = 8")]
        [TestCase(-1, -7,/*ExpectedException = typeof(FormatException),*/ TestName = "Тестирование площади при основании = -1, высоте = -7")]
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестировние площади при основании = double.MaxValue, высоте = double.MaxValue")]
        [TestCase(double.MinValue, double.MinValue, /*ExpectedException = typeof(FormatException), */
            TestName = "Тестирование площади при основании = double.MinValue, высоте = double.MinValue")]
        [TestCase(double.NaN, double.NaN, TestName = "Тестирование площади при основании = double.NaN, высоте = double.NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, TestName = "Тестирование площади при основании = -Inf, высоте = -Inf")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, TestName = "Тестирование площади при основании = +Inf, высоте = +Inf")]
        public void AreaTest(double mainside, double height)
        {
            var triangle = new Triangle(mainside,height);
            Assert.AreEqual(Math.Round(((height * mainside) / 3), 4), triangle.CalculatedArea);
        }
    }
}