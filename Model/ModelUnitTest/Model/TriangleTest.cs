using System;
using Model;
using NUnit.Framework;

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
        [TestCase(5, -7,ExpectedException = typeof(FormatException),
            TestName = "Тестирование площади при основании = 5, (ошибка)высоте = -7")]
        [TestCase(-7, 5, ExpectedException = typeof(FormatException),
            TestName = "Тестирование площади при (ошибка)основании = -7, высоте = 5")]
        [TestCase(-1, -7,ExpectedException = typeof(FormatException),
            TestName = "Тестирование площади при (ошибка)основании = -1, (ошибка)высоте = -7")]
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестировние площади при основании = double.MaxValue, высоте = double.MaxValue")]
        [TestCase(double.MaxValue, double.MinValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестировние площади при основании = double.MaxValue, (ошибка)высоте = double.MinValue")]
        [TestCase(double.MinValue, double.MaxValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестировние площади при (ошибка)основании = double.MinValue, высоте = double.MaxValue")]
        [TestCase(double.MinValue, double.MinValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при (ошибка)основании = double.MinValue, (ошибка)высоте = double.MinValue")]
        [TestCase(double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при основании = double.NaN, высоте = double.NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity,ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при (ошибка)основании = -Inf, (ошибка)высоте = -Inf")]
        [TestCase(double.NegativeInfinity, double.PositiveInfinity, ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при (ошибка)основании = -Inf, высоте = +Inf")]
        [TestCase(double.PositiveInfinity, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException), 
            TestName = "Тестирование площади при основании = +Inf, (ошибка)высоте = -Inf")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity,ExpectedException = typeof(NotFiniteNumberException), 
            TestName = "Тестирование площади при основании = +Inf, высоте = +Inf")]
        
        // Тестоывй метод проверки площади треугольника
        // Передаётся mainside-основание, height-высота
        public void AreaTest(double mainside, double height)
        {
            var triangle = new Triangle(mainside,height);
            Assert.AreEqual(Math.Round(((height * mainside) / 3), 4), triangle.CalculatedArea);
        }
    }
}