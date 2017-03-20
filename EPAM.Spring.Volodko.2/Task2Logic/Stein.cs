using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public class Stein:Inod
    {
        public long GDC(long a,long b)
        {
            return GDCStein(a, b);
        }
        public long GDC(long a,long b, params long[] arg)
        {
            var result = GDCStein(a, b);
            foreach (long item in arg)
            {
                result = GDCStein(result, item);
            }
            return result;
        }        
        private long GDCStein(long a, long b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GDCStein(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GDCStein(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GDCStein(a, b / 2);
            return GDCStein(b, (long)Math.Abs(a - b));
        }        
    }
}