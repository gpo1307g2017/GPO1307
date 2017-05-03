using System;

namespace Model
{
    public static class CheckCorrectValue
    {
        //TODO: XMl-комментарий
        public static void CheckDoubleValue(double ckeckedValue)
        {
            //TODO: Оформление кода
            if (ckeckedValue < 0)
        {
            throw new FormatException();
        }

        if (double.IsNaN(ckeckedValue) || double.IsInfinity(ckeckedValue))
        {
            throw new NotFiniteNumberException();
        }
    }
}

}
