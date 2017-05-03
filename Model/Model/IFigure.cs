
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
	    string TypeFigure { get; }


        /// <summary>
        /// Свейство расчёта площади фигуры
        /// </summary>
        /// <returns></returns>
        //[DisplayAttribute(Name = "Фамилия")]
        //[RequiredAttribute()]
        [System.ComponentModel.DisplayName("Figure Area")]
        double CalculatedArea { get; }

        //TODO: XMl-комментарий
        /// <summary>
        /// Метод вывода площади фигуры
        /// </summary>
        /// <param name="Площадь фигур"></param>
        string ShowArea();

        
    }
}
