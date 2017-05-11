using System;

namespace Model
{
    public static class CheckCorrectValue
    {
        /// <summary>
        /// Проверка на корректность ввода double значений
        /// </summary>
        /// <param name="ckeckedValue">Проверяемое double значение</param>
        public static void CheckDoubleValue(double ckeckedValue)
        {
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
