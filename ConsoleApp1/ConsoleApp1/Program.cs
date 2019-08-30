using System;
/*
 multiline comment
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isam5430.Class01A
{
    //mikeywu5, borismo1992
    class Program
    {
        //entry point in the console app
        static void Main(string[] args)
        {   //declaring a string 
            string person = "Michael";//initialization
            //string interpolation
            Console.WriteLine($"welcome to c# programming,{person}.");
            Console.WriteLine("welcome to c# programming,{0}", person);
            //Console.Write("welcome to..");
            Console.Write("Welcome to c# programming {0}", person);
            Console.Write(string.Format("Welcome to c# programming {0}", person));
            Console.Write("Welcome to c# programming," + person + ",");
            //Console.WriteLine(person);
            //Console.WriteLine(",");
            /*
             * variable:
             * datatype
             * simple type
             * int
             * bool(true/false)
             * char('a' , '0' !=0)
             * double/float(ieee 754)
             * decimal software- implementation of double/float
             * 
             * complex types
             * byte(binary content)
             * arrays(int[])
             * classes
             * struct
             * operators
             * +,-,*,/,%
             * boolean operators:
             * ==, !=,>,<, >=,<=;&&, ||, !
             * */


        }
    }
}
