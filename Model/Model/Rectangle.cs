using System;

namespace Model
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
   public class Rectangle : IFigure
    {

        private double _length;
        private double _width;

        /// <summary>
        /// Конструктор локального объявления длинны и ширины
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            if (length <= 0)
            {
                throw new System.FormatException();
            }
            if (width <= 0)
            {
                throw new System.FormatException();
            }
            _length = length;
            _width = width;
        }
        
        /// <summary>
        /// Метод расчёта площади прямоугольника
        /// </summary>
        public double CalculatedArea()
        {
            //TODO: Можно не заводить дополнительную переменную для расчёта
            double rectangleArea = _length * _width ;
            return rectangleArea;
        }

        /// <summary>
        /// Метод вывода площади прямоугольника
        /// </summary>
        /// <param name="area"></param>
        public void ShowArea(double area)
        {
            Console.WriteLine("Площадь прямоугольника с длинной " + _length + " и шириной " + _width + " = " + area);
        }
    }
}
