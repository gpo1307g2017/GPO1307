﻿using System;

namespace Model
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    [Serializable]
    public class Rectangle : IFigure
    {
        private double _length;
        private double _width;
        
        /// <summary>
        /// Конструктор локального объявления длинны и ширины
        /// </summary>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        public Rectangle(double length, double width)
        {
            CheckCorrectValue.CheckDoubleValue(length);
            CheckCorrectValue.CheckDoubleValue(width);
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
        /// <returns>Площадь прямоугольника в символьной форме</returns>
        public string ShowArea()
        {
            return Convert.ToString(Convert.ToString(CalculatedArea));
        }
        
        /// <summary>
        /// Тип фигуры = прямоугольник
        /// </summary>
        public FigureType TypeFigure => FigureType.Rectangle;
    }
}
