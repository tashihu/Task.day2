using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task2Logic
{
    public class Testing
    {
        public TimeSpan time { get; private set; }
        private Stopwatch watch = new Stopwatch();

        public delegate long GDC(long a, long b);
        public long diagnostic(GDC action, long a, long b, int count = 1)
        {
            int i=0;
            long result;
            watch.Start();
            do
            {
                result = action(a, b);
            } while (++i < count);
            watch.Stop();
            time = watch.Elapsed;
            watch.Reset();

            return result;
        }
        public long diagnostic(GDC action, long a, long b, long[] arg,int count =1)
        {
            int i = 0;
            long result;
            watch.Start();
            do
            {
                result = action(a, b);
                foreach (long item in arg)
                {
                    result = action(result, item);
                }
            } while (++i < count);

            watch.Stop();
            time = watch.Elapsed;
            watch.Reset();

            return result;
        }
    }
}
