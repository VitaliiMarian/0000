using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a+b;
            if (c<=100) 
            {
                Console.WriteLine("Можна було б просто написати число " + c );
            }
            else { Console.WriteLine("Занадто велике, не треба таке писати"); }
            Console.ReadKey();
        }
    }
}
