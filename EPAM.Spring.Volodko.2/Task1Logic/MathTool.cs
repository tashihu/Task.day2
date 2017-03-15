using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Задание 1.
•	Разработать метод, позволяющий вычислять корень n-ой степени из числа
 * методом Ньютона с заданной точностью. 
•	Проверить работу метода (сравнить полученный результат со значением, 
 * рассчитываемым с помощью метода Math.Pow библиотеки классов .NET Framework), 
 * используя консольное приложение с интерфейсом командной строки.
*/
namespace Task1Logic
{
    public class MathTool
    {
        #region public method
        /// <summary>
        /// find root by nuton method
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exponent"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static double FindRoot(double number, double exponent = 2, double epsilon = 0.001)
        {
            return nuton(number,exponent,epsilon);
        }
        #endregion 

        #region private method
        private static double nuton(double number, double exponent, double epsilon)
        {
            double x = 1;
            double nx;
            while (true)
            {
                nx = (x + number / x) / exponent;
                bool enoughtAccuracy = Math.Abs(x - nx) < epsilon;
                if (enoughtAccuracy) break;
                x = nx;
            }
            return x;
        }
        #endregion
    }
}
