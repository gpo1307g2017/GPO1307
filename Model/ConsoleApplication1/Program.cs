using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                IFigure figure = null;
                switch (select)
                {
                    case (int)TypesOfFigures.Triangle:
                        figure = new Triangle();
                        figure.CalculatedArea();
                        break;
                    case (int)TypesOfFigures.Rectangle:
                        figure = new Rectangle();
                        figure.CalculatedArea();
                        break;
                    case (int)TypesOfFigures.Ring:
                        figure = new Ring();
                        figure.CalculatedArea();
                        break;
                }
            }
        
      
}

//-------------------
Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");
            int select = Convert.ToInt16(Console.Read());
            /*if ( select != (1 | 2 | 3) )
            {
                try
                {
                    
                }
                catch ()
                {
                    Console.WriteLine("Введена неверная фигура");
                    throw;
                }
            }*/
            return select;

    }
}
