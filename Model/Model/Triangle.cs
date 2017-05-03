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
        //TODO: XMl-комментарий
        /// <summary>
        /// Конструктор лотального объявления основания и высоты
        /// </summary>
        /// <param name="Основание треугольника"></param>
        /// <param name="Высота треунгольника"></param>
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

        //TODO: XMl-комментарий
        /// <summary>
        /// Метод вывода площади треугольника
        /// </summary>
        /// <param name="Площадь треугольника"></param>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }
        //TODO: XMl-комментарий
        public string TypeFigure => "Triangle";
    }
}
