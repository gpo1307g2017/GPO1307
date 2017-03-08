using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Triangle
    {
        private double _mainside;

        public double mainside
        {
            get
            {
                return _mainside;
            }
            private set
            {
                value;
                _mainside = value;
            }
        }

        public double height;

        public override void CalculatedArea()
        {
            Console.Write("Введите основание треуголинька :");
            mainside = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту триугольника : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь треугольника с основанием " + mainside + " и высотой " + height + " = " +
                              ((height * mainside) / 3));
        }
    }
}
