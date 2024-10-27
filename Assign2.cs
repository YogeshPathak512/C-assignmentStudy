using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Assign2
    {
        static void Main(string[] args)
        {
            int rows = 10;
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine(); 
                }
                for (int k = 0; k <= rows - 1 - i; k++)
                {

                    Console.Write("*"); 
                }
                Console.WriteLine();

            }

        }
    }
}
