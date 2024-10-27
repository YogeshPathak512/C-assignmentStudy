using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Arraydemo
    {

        static void Main(string[] args)
        {
            
            // marks variable count is going till 100 
            int[] marks = new int[10];  //declaring array 
            int sum = 0;
            Console.WriteLine(marks.Length);
            for (int i = 0; i < marks.Length; i++)
            {

                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];

            }
            foreach (int z in marks)
            {


                Console.WriteLine(z);
            }

           Console.WriteLine("The sum of marks is {0}",sum);


            int[] arr = new int[]{ 1, 5, 7, 8 ,9};  // 1 element will occupy 4 bytes so 5 elements 4*5=20




        }
    }
}
