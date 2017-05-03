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

        //TODO: XMl-комментарий
        /// <summary>
        /// Конструктор локального объявления радиуса
        /// </summary>
        /// <param name="Радиус круга"></param>
        public Circle(double radius)
        {
            CheckCorrectValue.CheckDoubleValue(radius);
            _radius = radius;
        }



        /// <summary>
        /// Свойство площади круга
        /// </summary>
        public double CalculatedArea => Math.Round((Math.Pow(_radius, 2) * Math.PI), 4);

        //TODO: XMl-комментарий
        /// <summary>
        /// Метод вывода площади круга
        /// </summary>
        /// <param name="Площадь круга"></param>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }

        //TODO: XMl-комментарий
        /// <summary>
        /// Свойство определения типа фигуры
        /// </summary>
        public string TypeFigure => "Circle";
    }
}

