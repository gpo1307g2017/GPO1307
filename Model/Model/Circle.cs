using System;

namespace Model
{
    /// <summary>
    /// Круг
    /// </summary>
    class Circle
    {
        /// <summary>
        /// Переменная для радиуса
        /// </summary>
        private double _R;

        public double R
        {
            get
            {
                return _R;
            }

            set
            {
                Console.Write("Введите радиус круга");
                value = Console.Read();
                _R = value;
            }
        }

        /// <summary>
        /// Метод расчёта площади круга
        /// </summary>
        double CalculatedArea()
        {
            double circleArea = (Math.Pow(R, 3) * Math.PI);
            return circleArea;
        }

        /// <summary>
        /// Метод вывода площади круга
        /// </summary>
        /// <param name="area"></param>
        void ShowArea(double area)
        {
            Console.WriteLine("Площадь круга с радиусом " + _R + " = " + area);
        }
    }
}
