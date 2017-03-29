using System;
using System.Data;
using Model;


namespace ConsoleModel
{

    class ModelProg
    {
        static void Main(string[] args)
        {
            int select = 0;
         
            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");
            select = Convert.ToInt32(Console.ReadLine());
          

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

                    try
                    {
                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных в треугольнике");
                        throw;
                    }

                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
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

                    try
                    {
                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных в прямоугольнике");
                        throw;
                    }
                    
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
                /// <summary>
                /// Ветка круга
                /// </summary>
                case (int)TypesOfFigures.Ring:
                    Console.Write("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    figure = new Circle (radius);

                    try
                    {
                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Неверный формат данных в круге");
                        throw;
                    }
                    
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
                // 1 >= select >= 3    
                default:
                    Console.WriteLine("Введены неверные данные.");
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
            }
        }

    }
}
