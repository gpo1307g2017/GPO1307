using System;

namespace Model
{
    /// <summary>
    /// Перечисление фигур
    /// </summary>
    public enum TypesOfFigures
    {
        Triangle = 1,
        Rectangle,
        Ring
    };
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        void CalculatedArea();

        int SelectFigure();

        void GetFigure(int select);

    }

}