using System;

namespace Model
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        private double _radius;
        
        /// <summary>
        /// Конструктор локального объявления радиуса
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new System.FormatException();
            }
            _radius = radius;
        }


        /// <summary>
        /// Метод расчёта площади круга
        /// </summary>
        public double CalculatedArea()
        {
            //TODO: Можно не заводить дополнительную переменную для расчёта
            double circleArea = (Math.Pow(_radius, 3) * Math.PI);
            return circleArea;
        }

        /// <summary>
        /// Метод вывода площади круга
        /// </summary>
        /// <param name="area"></param>
        public void ShowArea(double area)
        {
            Console.WriteLine("Площадь круга с радиусом " + _radius + " = " + area);
        }
    }
}

