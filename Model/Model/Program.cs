using System;


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
                //TODO: В кейсе сделать метод вывода площади
                /// <summary>
                /// Выбор треугольника
                /// </summary>
                case (int) TypesOfFigures.Triangle:
                    Console.Write("Введите основание треугольника: ");
                    double mainsideTriangle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    double heigthTriangle = Convert.ToDouble(Console.ReadLine());
                    figure = new Triangle(mainsideTriangle, heigthTriangle);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.CalculatedArea();
                    break;
                /// <summary>
                /// Выбор прямоугольника
                /// </summary>
                case (int) TypesOfFigures.Rectangle:
                    Console.Write("Введите основание треугольника: ");
                    double lengthRectangle = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите высоту треугольника: ");
                    double widthRectangle = Convert.ToDouble(Console.ReadLine());
                    figure = new Rectangle(lengthRectangle, widthRectangle);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.CalculatedArea();
                    break;
                /// <summary>
                /// Выбор круга
                /// </summary>
                case (int) TypesOfFigures.Ring:
                    Console.Write("Введите радиус круга: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    figure = new Circle(radius);
                    /// <summary>
                    /// Вызов метода для подсчёта площади
                    /// </summary>
                    figure.CalculatedArea();
                    break;
            }
        }

    }
}