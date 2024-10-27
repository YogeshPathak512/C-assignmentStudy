using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ifelseiddemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter marks for 5 subjects ");
            int[] marks = new int [5];
            int sum = 0;
            for ( int i =0; i<marks.Length; i++ )
            {


                marks[i]=Convert.ToInt32(Console.ReadLine());
                 sum+=marks[i];
            }

            double average = sum/marks.Length;

            if (average < 35)
            {

                Console.WriteLine("Failed");

            }
            else if (average >= 35 && average < 50)
            {

                Console.WriteLine("Passed class");
            }

            else if (average >= 50 && average < 60)
            {

                Console.WriteLine("Second class");
            }

            else if (average >= 60 && average < 75)
            {
                Console.WriteLine("First class");
            }

            else
            { Console.WriteLine("Distinction "); }
        }
    }
}
