using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter no of rows ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            { 
                for (int z = rows; z >i; z--)
                {
                    Console.Write(" ");
                }


                for (int j =1; j<=i; j++)
                {

                  
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
       
}
