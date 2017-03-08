using System;

namespace Model
{
    public enum TypesOfFigures
    {
        Triangle = 1,
        Rectangle,
        Ring
    };
    
    public interface IFigure
    {
        void CalculatedArea();

        int SelectFigure();

        void GetFigure(int select);

    }

}