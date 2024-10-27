using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class triangledemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter no of rows ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i>0; i--)
            {
               


                for (int j = 0; j <= i; j++)
                {


                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
