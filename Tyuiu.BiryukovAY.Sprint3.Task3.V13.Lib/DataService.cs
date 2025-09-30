using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BiryukovAY.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            if (string.IsNullOrEmpty(value)) return 0;

            string digits = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                    digits += chr;
            }

            return digits == "" ? 0 : Convert.ToInt32(digits);
        }
    }
}
