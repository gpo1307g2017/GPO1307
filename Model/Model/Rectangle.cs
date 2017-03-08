using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Rectangle
    {
        public double length;
        public double width;

        public override void CalculatedArea()
        {
            Console.Write("Введите длинну прямоугольника :");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника : ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольника с длинной " + length + " и шириной " + width + " = " +
                              (length * width));
        }
    }
}
