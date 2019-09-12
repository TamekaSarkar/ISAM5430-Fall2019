using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {   //c.2 question 8  1,2,4,8,16,32,64
            int i = 1;
            while (i <= 100)
            {
                
                WriteLine(i);
                i = i *2 + 0;
               
            } 
            //c.2 question 9 100,50,25,...
            int j = 100;
            while (j >0)
            {
                Write(j + " ");
                j = j / 2 + 0;
               
                
            }
            //c.2 question10  100,50,25,12.5,6.25.....
            decimal k = 100;
            while (k > 1)
            {
                Write(k + " ");
                k =( k / 2 + 0);
            }
        }
    }
}
