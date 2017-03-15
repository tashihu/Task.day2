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
            MathTool tool = new MathTool();
            int a =100, b=234, c=432, d = 4323 ;
            tool.NodEvklid(1, 2, 3, 4, 5);
            Console.WriteLine("nod evklid {0} and {1} = {2},        time ={3}", a, b, tool.NodEvklid(a, b).ToString(), tool.time.ToString());
            Console.WriteLine("nod stein  {0} and {1} = {2},        time ={3}", a, b, tool.NodStein(a, b).ToString(), tool.time.ToString());
            Console.WriteLine("nod evklid {0} and {1} = {2},        time ={3}", a, b, tool.NodEvklid(a, b).ToString(), tool.time.ToString());
            Console.WriteLine("nod stein  {0} and {1} = {2},        time ={3}", a, b, tool.NodStein(a, b).ToString(), tool.time.ToString());
            Console.WriteLine("nod evklid {0} and {1} = {2},        time ={3}", a, c, tool.NodEvklid(a, c).ToString(), tool.time.ToString());
            Console.WriteLine("nod stein  {0} and {1} = {2},        time ={3}", a, c, tool.NodStein(a, c).ToString(), tool.time.ToString());
            Console.WriteLine("nod evklid {0} {1} {2} {3} = {4},    time ={5}", a, b, c, d, tool.NodEvklid(a, b, c, d).ToString(), tool.time.ToString());
            Console.WriteLine("nod stein  {0} {1} {2} {3} = {4},    time ={5}", a, b, c, d, tool.NodStein(a, b, c, d).ToString(), tool.time.ToString());
            Console.Read();
        }
    }
}
