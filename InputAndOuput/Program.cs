using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndOuput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.Write(" World");
            Console.WriteLine(", JD");

            Console.Write("Press Q to exit.");
            string ret= Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Ret:" + ret);

            Console.ReadKey();


            
        }
    }
}
