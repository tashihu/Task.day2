using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
/*
 Задание 2.
•	Разработать тип, в котором реализовать алгоритм Евклида для вычисления НОД двух целых чисел. 
 * Метод должен также определять значение времени, необходимое для выполнения расчета. 
 * Добавить к разработанному типу дополнительную функциональность в виде перегруженных 
 * методов вычисления НОД для трех и т.д. целых чисел. 
•	Добавить к разработанному типу метод, реализующий̆ алгоритм Стейна (бинарный̆ алгоритм Эвклида)
 * для расчета НОД двух целых чисел. Метод должен также определять значение времени, 
 * необходимое для выполнения расчетов. Добавить к разработанному типу дополнительную функциональность 
 * в виде перегруженных методов вычисления НОД для трех и т.д. целых чисел.
 */
namespace Task2Logic
{
    public class MathTool
    {
        #region fields
        public TimeSpan time { get; set; }
        private Stopwatch watch = new Stopwatch();
        #endregion

        #region public method
        /// <summary>
        /// culculation nod of 2 whole number. Using Evklid method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long NodEvklid(long a, long b)
        {
            StartTimer();
            var result =  Evklid(a, b);
            StopTimer();
            return result;
        }
        /// <summary>
        /// culculation nod of 3 or more whole number. Using Evklid method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="arg"></param>
        /// <returns></returns>
        public long NodEvklid(long a, long b, params long[] arg)
        {
            StartTimer();

            var result = Evklid(a, b);
            foreach (long item in arg)
            { 
                result = Evklid(result, item); 
            }

            StopTimer();
            return result;
        }
        /// <summary>
        /// culculation nod of 2 whole number. Using Stein method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long NodStein(long a, long b)
        {
            StartTimer();
            var result = Stein(a, b);
            StopTimer();
            return result;            
        }
        /// <summary>
        /// culculation nod of 3 or more whole number. Using Stein method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="arg"></param>
        /// <returns></returns>
        public long NodStein(long a, long b, params long[] arg)
        {
            StartTimer();
            var result = Stein(a, b);
            foreach (long item in arg)
            { result = Stein(result, item); }
            StopTimer();
            return result;
        }
        #endregion

        #region private method
        private void StartTimer()
        {
            watch.Start();
        }
        private void StopTimer()
        {
            watch.Stop();
            time = watch.Elapsed;
            watch.Reset();
        }
        private long Evklid(long a, long b)
        {
            long c = 0;
            while (b != 0)
            {
                c = b;
                b = a % b;
                a = c;
            }
            return a;            
        }
        private long Stein(long a, long b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * Stein(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return Stein(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return Stein(a, b / 2);
            return Stein(b, (long)Math.Abs(a - b));
        }
        #endregion
    }
}
