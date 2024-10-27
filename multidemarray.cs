using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class multidemarray
    {

        static void Main(string[] args)
        {
            //two dimension array has rows and columns 
            int[,] arr = new int[3, 2];//rows => 3 and column=>2 total elements 3 *2 = 6 
           for (int i =0; i<3; i++)
            {

                for ( int j=0; j<2;j++)
                {

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Printing 2 D Array ");
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 2; j++)
                {

                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }


            int[,] arr2 = { { 2, 4 }, { 3, 4 }, { 5, 5 } };

            Console.WriteLine(arr2.Length);

            int[] singlearr = new int[arr2.Length];
            int k = 0;
            foreach (int i in arr2)
            {

                singlearr[k] = i;
                k++;
            }

            Console.WriteLine("Printing in single dimension array ");
            foreach (int z in singlearr)
            {


                Console.WriteLine(z);
            }
           

        }
    }
}
