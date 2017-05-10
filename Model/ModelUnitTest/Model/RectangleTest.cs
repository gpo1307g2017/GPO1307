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

        [TestCase(-1, -7,ExpectedException = typeof(FormatException), TestName = "Тестирование площади при (ошибка)длине = -1, (ошибка)ширине = -7")]

        [TestCase(5, -7,ExpectedException = typeof(FormatException), TestName = "Тестирование площади при длине = 5, (ошибка)ширине = -7")]

        [TestCase(-7, 5,ExpectedException = typeof(FormatException), TestName = "Тестирование площади при (ошибка)длине = -7, ширине = 5")]

        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестировние площади при длине = double.MaxValue, ширине = double.MaxValue")]

        [TestCase(double.MinValue, double.MaxValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестировние площади при длине = double.MinValue, ширине = double.MaxValue")]

        [TestCase(double.MaxValue, double.MinValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестировние площади при длине = double.MaxValue, ширине = double.MinValue")]

        [TestCase(double.MinValue, double.MinValue, ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при длине = double.MinValue, ширине = double.MinValue")]

        [TestCase(double.NaN, double.NaN, ExpectedException = typeof(NotFiniteNumberException),
            TestName = "Тестирование площади при длине = double.NaN, ширине = double.NaN")]

        [TestCase(double.NegativeInfinity, double.NegativeInfinity, ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при длине = -Inf, ширине = -Inf")]

        //Проверяет 1 значение +inf  и говорит, что NotFinite, и забивает на 2 значение -inf (Format Exception)
        [TestCase(double.PositiveInfinity, double.NegativeInfinity, ExpectedException = typeof(NotFiniteNumberException), 
            TestName = "Тестирование площади при длине = +Inf, ширине = -Inf")]

        [TestCase(double.NegativeInfinity, double.PositiveInfinity, ExpectedException = typeof(FormatException), 
            TestName = "Тестирование площади при длине = -Inf, ширине = +Inf")]

        [TestCase(double.PositiveInfinity, double.PositiveInfinity, ExpectedException = typeof(NotFiniteNumberException), 
            TestName = "Тестирование площади при длине = +Inf, ширине = +Inf")]

        public void AreaTest(double length, double width)
        {
            var rectangle = new Rectangle(length,width);
            Assert.AreEqual(Math.Round(length * width, 4), rectangle.CalculatedArea);
        }
    }
}