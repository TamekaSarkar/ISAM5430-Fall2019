using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //D2. Question8 
            int[] array = { 1,1,1,1,1 };
            int clump = 0;
            bool flag = false;
            
            
            for(int i = 0; i < array.Length-1; i++)
            {

                if (array[i + 1] == array[i] && !flag)
                {
                    flag = true;
                    clump = clump + 1;
                }

                else if (array[i + 1] != array[i])
                {
                    flag = false;


                }
                }
                
            
            Console.WriteLine($"clump is {clump}.");

            // questions 10 centered avg

            Console.WriteLine("Enter the count1");
            int count1 = int.Parse(Console.ReadLine());
            int[] arr = new int[count1];
            int input = 0;
            int j = 0;
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            int Centeravg = 0;
            while (j < count1)
            {
                Console.WriteLine("enter input");
                 input = int.Parse(Console.ReadLine());
                arr[j] = input;
                max = Math.Max(max, arr[j]);
                min = Math.Min(min, arr[j]);
                sum = sum + arr[j];
                j = j + 1;
            }
            int c = max + min;
            
            Centeravg = (sum -c) / (count1 - 2);
            Console.WriteLine($"centered average is {Centeravg}.");

            // Question 11 not alone
            int[] array1 = { 2, 2, 2, 4,2 };
            bool flag1 = false;
           // bool notalone = false;
            int count2 = 0;
            for(int k = 1; k < array1.Length-2; k++)
            {
                if(array1[k-1] == 2 && array1[k+1] == 2)
                {
                    flag1 = true;
                    count2++;
                }
                else
                {
                    flag1 = false;
                    break;
                }
            }
            if(flag1== false)
            {
                Console.WriteLine("there is alone number");
            }
            else
            {
                Console.WriteLine("there is no alone number");
            }
            //Console.WriteLine($"notalone is {notalone}.");
            //Q12 
            int[] array2 = { 1, 4, 1, 4, 1 };
            int count_one = 0;
            int count4 = 0;
            bool flag2 = false;
            for(int a = 0; a < array2.Length; a++)
            {
                if (array2[a] == 1)
                {
                    count_one++;

                }
                 if (array2[a] == 4)
                {
                    count4++;
                }
            }
            if (count_one > count4)
            {
                flag2 = true;
            }
            Console.WriteLine($"More 1 than 4 is {flag2}.");

            //Q14

            int[] num = new int[4];
            int input1 = 0;
            int counter = 0;
            int maxcounter = 0;
            for(int m = 0; m < 4; m++)
            {
                Console.WriteLine("enter the number");
                input1 = int.Parse(Console.ReadLine());
                num[m] = input;
            }
            for (int p = 1; p < num.Length - 1; p++)
            {
                if (num[p] - num[p - 1] == num[p + 1] - num[p])
                {
                    counter++;
                    //maxcounter = Math.Max(maxcounter, counter);
                }
            }
               
                    maxcounter = Math.Max(maxcounter, counter);
              
            
       
            Console.WriteLine($"largest sequence is {maxcounter}");
            



            
                      


        }
    }
}
