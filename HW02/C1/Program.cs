using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
           //c.1 Questsion 1 20,19,18,17......1
            //num=20
            int num = 20;
            //while num <=1
            while (num >= 1)
            {
                //print num
                WriteLine(num);
                //num = num-1
                num = num - 1;
            }
            //c.1 question 2,4,6,8....
            int i = 2;
            while(i<= 10)
            {
                Write(i + "  " );
                i = i + 2;
            }

            // c.1 question 3 10,20,30.....
            int j = 0;
            while (j < 100)
            {
                Write(j + " ");
                j = j + 10;
            }

            // c.1 question 4  1,5,7,11,13,17,19
            int k = 1;
            while(k < 20)
            {
                if(k%2 == 1 && k%3 != 0)
                {
                    Write(k + "  ");
                }
                k = k + 1;
            }
            // c.1 question 6 
            int a = 1;
            while (a <= 100)
            {
                if ((a%3 !=0 && a%5 !=0) || (a%3 ==0 && a%5 == 0))
                {
                    WriteLine(a);
                }
                a = a + 1;
            }
            //c.1 question7 

            char c = 'a';
            while(c <= 'z')
            {
                Write(c + " ");
                c++;
                
            }
            //c.1 question 5
            int m = 4;
            int result = 0;
            while (m < 10)
            {
                result = (int )Math.Pow(m,2);
                WriteLine(result);
                m = m + 1;
            }
           

            
        }
       
         

    }
}
