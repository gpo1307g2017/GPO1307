namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Метод расчёта площади фигуры
        /// </summary>
        /// <returns></returns>
        double CalculatedArea();

        /// <summary>
        /// Метод вывода площади фигуры
        /// </summary>
        /// <param name="area"></param>
        void ShowArea(double area);


    }
}
