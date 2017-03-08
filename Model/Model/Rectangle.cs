using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Переменная для длинны
        /// </summary>
        private double _length;
      
        public double length
        {
            get
            {
                return _length;
            }

            set
            {
                Console.Write("Введите длинну прямоугольника");
                value = Console.Read();
                _length = value;
            }
        }

        /// <summary>
        /// Переменная для ширины
        /// </summary>
        private double _width;

        public double width
        {
            get
            {
                return _width;
            }

            set
            {
                Console.Write("Введите ширину прямоугольника");
                value = Console.Read();
                _width = value;
            }
        }


        /// <summary>
        /// Метод расчёта площади прямоугольника
        /// </summary>
        void CalculatedArea()
        {
            Console.WriteLine("Площадь прямоугольника с длинной " + _length + " и шириной " + _width + " = " + (length * width));
        }
    }
}
