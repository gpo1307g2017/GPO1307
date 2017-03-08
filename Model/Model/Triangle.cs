using System;

namespace Model
{
    /// <summary>
    /// Треугольник
    /// </summary>
    class Triangle
    {
        /// <summary>
        /// Переменная для основания
        /// </summary>
        private double _mainside;

        public double mainside
        {
            get
            {
                return _mainside;
            }
            private set
            {
                Console.Write("Введите основание треугольника");
                value = Console.Read();
                _mainside = value;
            }
        }

        /// <summary>
        /// Переменная для высоты
        /// </summary>
        private double _height;

        public double height
        {
            get
            {
                return _height;
            }

            set
            {
                Console.Write("Введите высоту треугольника");
                value = Console.Read();
                _height = value;
            }
        }

        /// <summary>
        /// Метод расчёта прощади треугольника
        /// </summary>
        void CalculatedArea()
        {
            Console.WriteLine("Площадь треугольника с основанием " + _mainside + " и высотой " + _height + " = " + ((height * mainside) / 3));
        }
    }
}
