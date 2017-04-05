namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        //TODO: Правильнее сделать свойством
        /// <summary>
        /// Метод расчёта площади фигуры
        /// </summary>
        /// <returns></returns>
        double CalculatedArea();

        //TODO: Такой подход не корректен по нескольким причинам:
        //TODO: 1. Метод show использует консольный вывод, в следующей лабораторной формат вывода меняется, поэтому правильнее не привязываться к типу вывода
        //TODO: 2. Зачем методу area на вход, если у класса уже есть area?
        /// <summary>
        /// Метод вывода площади фигуры
        /// </summary>
        /// <param name="Площадь фигур"></param>
        void ShowArea(double area);


    }
}
