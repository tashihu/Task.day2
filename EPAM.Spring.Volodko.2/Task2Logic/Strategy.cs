using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    //public delegate long GDC(long a, long b);
    public interface Inod
    {
         long GDC(long a, long b);
         long GDC(long a, long b, long[] arg);
    }
    public class Strategy
    {
        public Inod _gdc { get; set;}

        public Strategy(Inod gdc)
        {
            _gdc = gdc;
        }
        public long calculateGDC(long a, long b)
        {
            return _gdc.GDC(a, b);
        }
        public long calculateGDC(long a, long b,long[] c)
        {
            return _gdc.GDC(a, b, c);
        }
    }

}
