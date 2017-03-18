using System;
using Model;


namespace ConsoleModel
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");
            //TODO: При вводе значений 1, 2 или 3 принемает select как 49,50 или 51 соответственно
            int select = Convert.ToInt32(Console.Read());

            select = 1;

            IFigure figure = null;
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
                    //TODO: Непонятное исключение типа "Входная строка имела неверный формат."?
                    double mainsideTriangle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    double heigthTriangle = Convert.ToDouble(Console.ReadLine());
                    figure = new Triangle(mainsideTriangle, heigthTriangle);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);
                    Console.Read();
                    break;
                /// <summary>
                /// Ветка прямоугольника
                /// </summary>
                case (int)TypesOfFigures.Rectangle:
                    Console.Write("Введите основание треугольника: ");
                    double lengthRectangle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    double widthRectangle = Convert.ToDouble(Console.ReadLine());
                    figure = new Rectangle(lengthRectangle, widthRectangle);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);
                    Console.Read();
                    break;
                /// <summary>
                /// Ветка круга
                /// </summary>
                case (int)TypesOfFigures.Ring:
                    Console.Write("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    figure = new Circle(radius);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figureArea = figure.CalculatedArea();
                    figure.ShowArea(figureArea);
                    Console.Read();
                    break;
            }
        }

    }
}
