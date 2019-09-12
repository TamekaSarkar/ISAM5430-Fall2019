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
            int z = 0;
            int zero = 0;
            int even = 0;
            int even1 = 0;
            int odd1 = 0;
            int sum_firsthalf = 0;
            int sum_secondhalf = 0;
            int[] array = new int[6];
            int max = 0;
            int min = 0;
            bool flag = true;
            int cnt_var = 0;
           
            int input = 0;
            while (i < count)
            {
                WriteLine("enter a number");
                input = int.Parse(Console.ReadLine());
                array[i] = input;
                

                i = i + 1;
            }
           for(int j = 0; j <count; j++)
            {
                if (array[j] > 0)
                {
                    z++;
                }
                if (array[j] == 0)
                {
                    zero++;
                }
                if (array[j] % 2 == 0)
                {
                    even++;
                }
                if (array[j] > max)
                {
                    max = Math.Max(max, array[j]);

                }
                if (array[j] < min)
                {
                    min = Math.Min(min, array[j]);
                }
                
            }
           //d.1 question 1 answer
            WriteLine($"three positive integer is {z}.");
            //d.1 question 2 answer
            WriteLine($"number of zeros is {zero}.");
            //d.1 question 3 ans
            WriteLine($"number of even is {even}.");
            //d.1 question 4 answer
            WriteLine($"largest number  is {max}.");
            //d.1 question5 answer
            WriteLine($"smallest number  is {min}.");
            // d1 question 4
            for ( int j = 1; j < count; j++)
            {
                if(array[j]> array[j - 1])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if(flag == true)
            {
                //d1 question 4 answer
                WriteLine("asending order");
            }
            // d.1 question 7 
            if(count%2 == 0)
            {
                count = even1;
                if (count == even1)
                {
                    cnt_var = (count / 2) + 1;
                }
            }
            if(count%2 == 1)
            {
                count = odd1;
                if(count == odd1)
                {
                    cnt_var = (count / 2) + 2;
                }
            }

            for(int k =0;k<= count / 2; k++)
            {
                sum_firsthalf = sum_firsthalf + array[k];
            }
            for(int L = cnt_var; L <= count - 1; L++)
            {
                sum_secondhalf = sum_secondhalf + array[L];
            }
            if(sum_firsthalf == sum_secondhalf)
            {
                WriteLine("first half is equal to second half");
            }
            else
            {
                WriteLine("firsthalf is not equal to second half");
            }









        }
    }
}
