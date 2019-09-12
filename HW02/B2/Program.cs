using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print enter first number
            WriteLine("Enter first integer");
            // input first number
            int a = int.Parse(ReadLine());
            // print enter second number
            WriteLine("Enter second integer");
            // input second number
            int b = int.Parse(ReadLine());
            // print enter third number
            WriteLine("Enter third integer");
            // input third number
            int c = int.Parse(ReadLine());
            // if a>b and a<c or a>c and a<b
            if((a>b && a < c) || (a>c && a<b))
            {
                // print a
                WriteLine($"Middle number is, {a}.");
            }
            // else if a>b and b<c or c>b and b<a
            else if ((b>a && b<c) || (c>b && a < b))
            {
                // print b
                WriteLine($"middle number is, {b}.");
            }
            // 
            else 
            {
                // print c
                WriteLine($"middle number is , {c}.");
            }
            
           

        }
    }
}
