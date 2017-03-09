namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    interface IFigure
    {
        double CalculatedArea();

        void ShowArea(double area);

        int SelectFigure();

        void GetFigure(int select);
    }
}
