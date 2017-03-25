using System;

namespace Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {

        private double _mainside;
        private double _height;

        /// <summary>
        /// Конструктор лотального объявления основания и высоты
        /// </summary>
        /// <param name="mainside"></param>
        /// <param name="heigth"></param>
        public Triangle(double mainside, double heigth)
        {
            _mainside = mainside;
            _height = heigth;
        }


        /// <summary>
        /// Метод расчёта прощади треугольника
        /// </summary>
        public double CalculatedArea()
        {
            double triangleArea = ((_height * _mainside) / 3);
            return triangleArea;
        }

        /// <summary>
        /// Метод вывода площади треугольника
        /// </summary>
        /// <param name="area"></param>
        public void ShowArea(double area)
        {
            Console.WriteLine("Площадь треугольника с основанием " + _mainside + " и высотой " + _height + " = " + (double) area);
        }
    }
}
