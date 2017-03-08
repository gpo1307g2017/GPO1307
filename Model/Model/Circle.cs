using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Circle
    {
        public double R;

        public override void CalculatedArea()
        {
            Console.Write("Введите радиус круга : ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь круга с радиусом " + R + " = " + (Math.Pow(R, 3) * Math.PI));
        }
    }
}
