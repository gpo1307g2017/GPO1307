using System;

namespace Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    [Serializable]
    public class Triangle : IFigure
    {

        private double _mainside;
        private double _height;
        //TODO: XMl-комментарий(check)
        /// <summary>
        /// Конструктор локального объявления основания и высоты
        /// </summary>
        /// <param name="mainside">Основание треугольника</param>
        /// <param name="heigth">Высота треугольника</param>
        public Triangle(double mainside, double heigth)
        {
            CheckCorrectValue.CheckDoubleValue(mainside);
            CheckCorrectValue.CheckDoubleValue(heigth);
            _mainside = mainside;
            _height = heigth;
        }

        /// <summary>
        /// Метод расчёта прощади треугольника
        /// </summary>        
        public double CalculatedArea => Math.Round(((_height * _mainside) / 3), 4);

        //TODO: XMl-комментарий(check)
        /// <summary>
        /// Метод вывода площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника в символьной форме</returns>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }

        //TODO: XMl-комментарий(check)
        /// <summary>
        /// Тип фигуры = треугольник
        /// </summary>
        public FigureType TypeFigure => FigureType.Triangle;
    }
}
