using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print enter first number
            WriteLine("Enter fisrt integer");
            //Input first number
            int first = int.Parse(ReadLine());

            //print enter second number
            WriteLine("Enter second number");
            //Input second number
            int second = int.Parse(ReadLine());
            // if first > second

            if (first > second)
            {
                // print first
                WriteLine("first");
            }
            // else if second >first
            else if (second> first)
            {
                // print second number
                WriteLine("second");
            }
            else
            {
                // print both are same
                WriteLine("both are same");
            }

        }
    }
}
