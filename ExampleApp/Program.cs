using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsciiArt;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            var x = Console.ReadLine();
            //Console.WriteLine($"Hello, {x}!");
            AsciiArt.AsciiArt.Write(x, 25, "Arial");
            Console.ReadKey();
        }
    }
}
