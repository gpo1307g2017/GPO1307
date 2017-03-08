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
        void CalculatedArea()
        {
            Console.WriteLine("Площадь круга с радиусом " + _R + " = " + (Math.Pow(R, 3) * Math.PI));
        }
    }
}
