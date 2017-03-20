using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public class Evklid: Inod
    {
        public long GDC(long a, long b)
        {
            return GDCEvklid(a, b);
        }
        public long GDC(long a, long b, params long[] arg)
        {
            var result = GDCEvklid(a, b);
            foreach (long item in arg)
            {
                result = GDCEvklid(result, item);
            }
            return result;
        }
       
        private long GDCEvklid(long a, long b)
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
    }

}
