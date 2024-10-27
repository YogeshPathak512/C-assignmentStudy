using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class jaggedarray
    {
        static void Main(string[] args)
        {
            //Jagged array 

            int[][] arr = new int[3][];  //declare jagged array  rows are fixed but column are varibles

            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[1];
               for ( int i = 0; i < 3; i++)
            {


                for( int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                
                }
            }

            Console.WriteLine("Printing jaaged array ");

            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);

                }

                Console.WriteLine();
            }

            Console.WriteLine(arr[0][2]);


            
        }
    }
}
