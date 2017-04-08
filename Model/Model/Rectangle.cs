﻿using System;

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
        /// <param name="Длинна прямоугольника"></param>
        /// <param name="Ширина прямоугольника"></param>
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
        public double CalculatedArea => Math.Round(_length * _width, 4);


        /// <summary>
        /// Метод вывода площади прямоугольника
        /// </summary>
        /// <param name="Площадь прямоугольника"></param>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }

        public string TypeFigure => "Rectangle";
    }
}
