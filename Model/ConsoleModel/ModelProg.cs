using System;
using Model;
using System.Text.RegularExpressions;


namespace ConsoleModel
{

    class ModelProg
    {
       static string StringFormatExeption(string stringValue)
        {
            var numberPatern = new Regex(@"[0-9]");

            try
            {
                stringValue = Console.ReadLine();
                if (numberPatern.IsMatch(stringValue)) { }
                else throw new FormatException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Неверный формат данных сторон фигры. Обнаружены символы, а ожидались цифры.");
                throw;
            }

            return stringValue;
        }

        static void Main(string[] args)
        {
                  
            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");

            //Переменная проверки значений выборки фигуры
            var stringPattern = new Regex ( @"^[1-3]$");
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
                Console.WriteLine("Неверный формат данных выбора фигуры. Обнаружены символы, а ожидались цифры");
                throw;
            }

            int select = int.Parse(stringSelect);

            IFigure figure;
            double figureArea;

            switch (select)
            {
                //TODO: Ниже много дублирующихся фрагментов, исправьте.
                case (int)TypesOfFigures.Triangle:
                    Console.Write("Введите основание треугольника: ");

                    string stringMainsideTriangle = null;
                    stringMainsideTriangle = StringFormatExeption(stringMainsideTriangle);
                    double mainsideTriangle = double.Parse(stringMainsideTriangle);

                    Console.Write("Введите высоту треугольника: ");

                    string stringHeigthTriangle = null;
                    stringHeigthTriangle = StringFormatExeption(stringHeigthTriangle);
                    double heigthTriangle = double.Parse(stringHeigthTriangle);

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

                    string stringLengthRectangle = null;
                    stringLengthRectangle = StringFormatExeption(stringLengthRectangle);
                    double lengthRectangle = double.Parse(stringLengthRectangle);
               
                    Console.Write("Введите ширину прямоугольника: ");


                    string stringWidthRectangle = null;
                    stringWidthRectangle = StringFormatExeption(stringWidthRectangle);
                    double widthRectangle = double.Parse(stringWidthRectangle);

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

                    string stringRadiusCirlce = null;
                    stringRadiusCirlce = StringFormatExeption(stringRadiusCirlce);
                    double radiusCirlce = double.Parse(stringRadiusCirlce);

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
