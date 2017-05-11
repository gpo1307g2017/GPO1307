using System;

namespace Model
{
    /// <summary>
    /// Круг
    /// </summary>
    [Serializable]
    public class Circle : IFigure
    {
        private double _radius;
        
        /// <summary>
        /// Конструктор локального объявления радиуса
        /// </summary>
        /// <param name="radius">Double значение радиуса круга</param>
        public Circle(double radius)
        {
            CheckCorrectValue.CheckDoubleValue(radius);
            _radius = radius;
        }

        /// <summary>
        /// Свойство площади круга
        /// </summary>
        public double CalculatedArea => Math.Round((Math.Pow(_radius, 2) * Math.PI), 4);
        
        /// <summary>
        /// Метод вывода площади круга
        /// </summary>
        /// <returns>Площадь круга в символьной форме</returns>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }
        
        /// <summary>
        /// Тип фигуры = круг
        /// </summary>
        public FigureType TypeFigure => FigureType.Circle;
    }
}

