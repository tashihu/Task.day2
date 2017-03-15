using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;
namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nuton from {0} = {1} , Math.Pow = {2}",9, MathTool.FindRoot(9,2,1e-8), Math.Pow(MathTool.FindRoot(9), 2));
            Console.Read();
        }
       
    }
}
