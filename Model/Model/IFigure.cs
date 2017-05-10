
namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Свойство вывода вида фигуры
        /// </summary>
        [System.ComponentModel.DisplayName("Figure Type")]
	    FigureType TypeFigure { get; }


        /// <summary>
        /// Свейство расчёта площади фигуры
        /// </summary>
        [System.ComponentModel.DisplayName("Figure Area")]
        double CalculatedArea { get; }

        //TODO: XMl-комментарий(check)
        /// <summary>
        /// Метод вывода площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры в символьном виде</returns>
        string ShowArea();

        
    }
}
