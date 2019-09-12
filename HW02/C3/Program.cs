using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            // c.3 question 11.
            int i = 1;
            int fact = 1;
            while (i <= 6)
            {
                fact = fact * i;
                Console.Write(fact + " ");
                i = i + 1;
            }
            // c.3 question 12
            int a = 0;
            int b = 1;
            int c = 0;
            int j = 1;
            Console.WriteLine("enter no of times ");
            int n = int.Parse(Console.ReadLine());
            while(j < n)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                j = j + 1;
            }


        }
    }
}
