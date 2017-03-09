using System;
using ConsoleApplication1;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");
            
            int select = Convert.ToInt16(Console.Read());
            
            IFigure figure = null;

            /// <summary>
            /// Выборка фигуры
            /// </summary>
            switch (select)
            {
                /// <summary>
                /// Выбор треугольника
                /// </summary>
                case (int) TypesOfFigures.Triangle:
                    figure = new Triangle();
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.ShowArea(CalculatedArea());
                    break;
                /// <summary>
                /// Выбор прямоугольника
                /// </summary>
                case (int) TypesOfFigures.Rectangle:
                    figure = new Rectangle();
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.ShowArea(CalculatedArea());
                    break;
                /// <summary>
                /// Выбор круга
                /// </summary>
                case (int) TypesOfFigures.Ring:
                    figure = new Circle();
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.ShowArea(CalculatedArea());
                    break;
            }

        }
    }
}
