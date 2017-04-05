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
        /// <param name="Радиус круга"></param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new System.FormatException();
            }
            _radius = radius;
        }





        /// <summary>
        /// Свойство площади круга
        /// </summary>
        public double CalculatedArea() => (Math.Pow(_radius, 3) * Math.PI);

        /// <summary>
        /// Метод вывода площади круга
        /// </summary>
        /// <param name="Площадь круга"></param>
        public void ShowArea(double area)
        {
            Console.WriteLine("Площадь круга с радиусом " + _radius + " = " + area);
        }
    }
}

