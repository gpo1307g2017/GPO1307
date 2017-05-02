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
                if (!numberPatern.IsMatch(stringValue))
                { 
					throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных сторон фигры. Обнаружены символы, а ожидались цифры.");
            }

            return stringValue;
        }

        static void Main(string[] args)
        {
            double t = double.MaxValue;
            Console.WriteLine("double.MaxValue = {0}",t);
                  
            Console.Write("Выберите фигуру (1-треугольник; 2-прямоугольник; 3-круг): ");

            //Переменная проверки значений выборки фигуры
            var stringPattern = new Regex ( @"^[1-3]$");
            string stringSelect;

            try
            {
                stringSelect = Console.ReadLine();
                if (stringPattern.IsMatch(stringSelect) != true)
                {
                    throw new FormatException();
                }

            }
            catch(FormatException)
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
                        figureArea = figure.CalculatedArea;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный формат данных в треугольнике");
                        throw;
                    }

                    Console.WriteLine("Площадь тругольника с основанием {0} и высотой {1} = {2}", mainsideTriangle, heigthTriangle, figure.ShowArea());

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

                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный формат данных в прямоугольнике");
                        throw;
                    }

                    figureArea = figure.CalculatedArea;
                    Console.WriteLine("Площадь прямоугольника с шириной {0} и длиной {1} = {2}", lengthRectangle, widthRectangle, figure.ShowArea());
                    
                                       
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
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный формат данных в круге");
                        throw;
                    }

                    figureArea = figure.CalculatedArea;
                    Console.WriteLine("Площадь круга с радиусом {0} = {1}", radiusCirlce , figure.ShowArea());
                            
                    Console.WriteLine("Нажмите любую кнопку для продолжения...");
                    Console.Read();
                    break;
            }
        }

    }
}
