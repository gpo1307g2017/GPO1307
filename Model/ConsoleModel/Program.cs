using System;
using Model;


namespace ConsoleModel
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");
            int select = Convert.ToInt32(Console.ReadLine());

            IFigure figure;
            double figureArea;

            /// <summary>
            /// Выборка фигуры
            /// </summary>
            switch (select)
            {
                /// <summary>
                /// Ветка треугольника
                /// </summary>
                case (int)TypesOfFigures.Triangle:
                    Console.Write("Введите основание треугольника: ");
                    double mainsideTriangle = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите высоту треугольника: ");
                    double heigthTriangle = Convert.ToDouble(Console.ReadLine());

                    figure = new Triangle(mainsideTriangle, heigthTriangle);
                   
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);

                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.Read();
                    break;
                /// <summary>
                /// Ветка прямоугольника
                /// </summary>
                case (int)TypesOfFigures.Rectangle:
                    Console.Write("Введите основание прямоугольника: ");
                    double lengthRectangle = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите высоту треугольника: ");
                    double widthRectangle = Convert.ToDouble(Console.ReadLine());

                    figure = new Rectangle(lengthRectangle, widthRectangle);
                    
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);

                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.Read();
                    break;
                /// <summary>
                /// Ветка круга
                /// </summary>
                case (int)TypesOfFigures.Ring:
                    Console.Write("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    figure = new Circle(radius);
               
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);

                    Console.WriteLine("Нажмите любую кнопку для продолжения");
                    Console.Read();
                    break;
            }
        }

    }
}
