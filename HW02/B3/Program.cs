using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 0 and 4");
            decimal gpa = decimal.Parse(Console.ReadLine());
            //decimal gpa = 0;
            if(gpa>= 0 && gpa <= 4)
            {
                Console.WriteLine("gpa is valid");
            }
            else
            {
                Console.WriteLine("gpa is invalid");
            }
            decimal GPA = (int)(3 * gpa + 0.5m);
            string grade = null;
            switch (GPA)
            {
                case 12:
                case 11:
                    {
                        grade = "A";
                        break;

                    } 
                    
                case 9:
                case 10:
                case 8:
                    {
                        grade = "B";
                        break;
                    }
                case 6:
                case 7:
                case 5:
                    {
                        grade = "C";
                        break;
                    }
                case 3:
                case 4:
                    {
                        grade = "D";
                        break;
                    }
              
                    
                default:
                    {
                        grade = "F";
                        break;
                    }

            }
            if((GPA ==11)||(GPA == 8 ) || (GPA == 5))
            {
                WriteLine(grade + "_");
            }
            else if(GPA == 7 || GPA == 4 ||GPA==10)
            {
                WriteLine(grade + "+");
            }
            else if(GPA == 12)
            {
                WriteLine("grade A");
            }
            else if(GPA == 9)
            {
                WriteLine("grade B");
            }
            else if(GPA == 6)
            {
                WriteLine("grade C");
            }
            else if(GPA == 3)
            {
                WriteLine("grade D");
            }
            else
            {
                WriteLine("grade F");
            }
                
                
                

        }
    }
}
