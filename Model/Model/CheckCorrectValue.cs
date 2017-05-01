using System;

namespace Model
{
    public static class CheckCorrectValue
    {
        public static void CheckDoubleValue(double ckeckedValue)
        {
            if (ckeckedValue <= 0)
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
