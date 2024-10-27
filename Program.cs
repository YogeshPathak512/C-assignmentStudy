using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To find area of rectangle 
            /* Multiple Line  */
            Console.WriteLine("Please enter length and breadth ");
            //declare variables 

            int height, width, area;
            //Difference between Convert.ToInt32 and int.Parse and in.TryParse 

            height = Convert.ToInt32(Console.ReadLine());

            width= int.Parse(Console.ReadLine());

            area = height * width;
            Console.WriteLine("Area of rectangle of height {0} and width {1} is {2} " , height,width,area);

            Console.Read();

        }
    }
}
