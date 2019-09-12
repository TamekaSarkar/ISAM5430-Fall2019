using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter count");
            int count = int.Parse(Console.ReadLine());
            int i = 0;
            decimal sum = 0;
            decimal avg = 0;
            int input = 0;
            while (i< count)
            {
                WriteLine("enter a number");
                input = int.Parse(Console.ReadLine());
                sum = sum + input;
                
                i = i + 1;
            }
            WriteLine($"sum is {sum}.");
            avg = (decimal)( sum / count);
            WriteLine( $"avg is {avg}.");

        }
    }
}
