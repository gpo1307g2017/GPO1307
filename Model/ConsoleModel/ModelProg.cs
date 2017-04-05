using System;
using Model;
using System.Text.RegularExpressions;


namespace ConsoleModel
{

    class ModelProg
    {
        static void Main(string[] args)
        {
                  
            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");

            //Переменная проверки значений выборки фигуры
            var stringPattern =new Regex ( @"^[1-3]$");
            string stringSelect;

            try
            {
                stringSelect = Console.ReadLine();
                //TODO: Плохая практика. Можно написать без пустых скобок. Ниже тоже переделайте.
                if (stringPattern.IsMatch(stringSelect)) { }
                else throw new FormatException();
            }
            catch(FormatException e)
            {
                //TODO: Зачем заново бросаете исключение?
                Console.WriteLine("Неверный формат данных выбора фигуры");
                throw;
            }

            int select = int.Parse(stringSelect);

            IFigure figure;
            double figureArea;

            var numberPatern = new Regex(@"[0-9]");

            //TODO: xml комментарии не должны быть внутри метода
            /// <summary>
            /// Выборка фигуры
            /// </summary>
            switch (select)
            {
                //TODO: Ниже много дублирующихся фрагментов, исправьте.
                case (int)TypesOfFigures.Triangle:
                    Console.Write("Введите основание треугольника: ");

                    string stringMainsideTriangle;
                    double mainsideTriangle;
                    
                    try
                    {
                        stringMainsideTriangle = Console.ReadLine();
                        if (numberPatern.IsMatch(stringMainsideTriangle)) {  }
                        else throw new FormatException();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных основания треугольника");
                        throw;
                    }

                    mainsideTriangle = double.Parse(stringMainsideTriangle);

                    Console.Write("Введите высоту треугольника: ");

                    string stringHeigthTriangle;
                    double heigthTriangle;

                    try
                    {
                        stringHeigthTriangle = Console.ReadLine();
                        if (numberPatern.IsMatch(stringHeigthTriangle)) { }
                        else throw new FormatException();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных высоты треугольника");
                        throw;
                    }

                    heigthTriangle = double.Parse(stringMainsideTriangle);

                    try
                    {
                        figure = new Triangle(mainsideTriangle, heigthTriangle);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных в треугольнике");
                        throw;
                    }

                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);

                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
               
                case (int)TypesOfFigures.Rectangle:
                    Console.Write("Введите длину прямоугольника: ");

                    string stringLengthRectangle;
                    double lengthRectangle;

                    try
                    {
                        stringLengthRectangle = Console.ReadLine();
                        if (numberPatern.IsMatch(stringLengthRectangle)) { }
                        else throw new FormatException();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных длины прямоугольника");
                        throw;
                    }

                    lengthRectangle = double.Parse(stringLengthRectangle);
               
                    Console.Write("Введите ширину прямоугольника: ");

                    string stringWidthRectangle;
                    double widthRectangle;

                    try
                    {
                        stringWidthRectangle = Console.ReadLine();
                        if (numberPatern.IsMatch(stringWidthRectangle)) { }
                        else throw new FormatException();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных ширины прямоугольника");
                        throw;
                    }

                    widthRectangle = double.Parse(stringWidthRectangle);

                    try
                    {
                        figure = new Rectangle(lengthRectangle, widthRectangle);
                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных в прямоугольнике");
                        throw;
                    }

                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);
                                       
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
                
                case (int)TypesOfFigures.Ring:
                    Console.Write("Введите радиус круга: ");

                    string stringRadiusCirlce;
                    double radiusCirlce;

                    try
                    {
                        stringRadiusCirlce = Console.ReadLine();
                        if (numberPatern.IsMatch(stringRadiusCirlce)) { }
                        else throw new FormatException();
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Неверный формат данных радиуса круга");
                        throw;
                    }

                    radiusCirlce = double.Parse(stringRadiusCirlce);

                    try
                    {
                        figure = new Circle(radiusCirlce);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Неверный формат данных в круге");
                        throw;
                    }

                        figureArea = figure.CalculatedArea();
                        figure.ShowArea(figureArea);
                            
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
            }
        }

    }
}
