using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy tool = new Strategy(new Evklid());
            
            int a =100, b=234, c=432, d = 4323 ;
            Testing test = new Testing();

            Console.WriteLine("nod evklid {0} and {1} = {2},        time ={3}", a, b, test.diagnostic(tool.calculateGDC, a, b,1000), test.time.TotalMilliseconds.ToString());
            tool._gdc = new Stein();
            //tool = new Strategy(new Stein());
            Console.WriteLine("nod stein {0} and {1} = {2},        time ={3}", a, b, test.diagnostic(tool.calculateGDC, a, b, 1000), test.time.TotalMilliseconds.ToString());

            Console.Read();
        }
    }
}
