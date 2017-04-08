namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Свейство расчёта площади фигуры
        /// </summary>
        /// <returns></returns>
        double CalculatedArea { get; }

        /// <summary>
        /// Метод вывода площади фигуры
        /// </summary>
        /// <param name="Площадь фигур"></param>
        string ShowArea();

        /// <summary>
        /// Свойство вывода вида фигуры
        /// </summary>
	    string TypeFigure { get; }
    }
}
