using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Common
{
    public class ImputValidavor
    {
        public static bool TryGetNumber(string input, out int number, out string errorMessage)
        {
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(input);
                    errorMessage = "";
                    return true;

                }
                catch (FormatException)
                {
                    number = 0;
                    errorMessage = "Пожалуйста, введите число";
                    return false;
                }
                catch (OverflowException)
                {
                    number = 0;
                    errorMessage = "Вы ввели слишком длинный ответ! Ответом считается -2*10^9 до 2*10^9";
                    return false;
                }
            }
        }
    }
}
