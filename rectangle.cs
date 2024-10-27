using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter width and height for rectangle ");
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < width; i++)
            {


                for (int j = 0; j < height; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
