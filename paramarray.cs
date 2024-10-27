using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class paramarray
    {
        public int add(params int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            
            }
            return sum;

        
        }

        static void Main(string[] args)
        {

            paramarray obj = new paramarray ();
            int sum = obj.add(12, 2, 3);

            Console.WriteLine("The sum of array " + sum);

            int sum1 = obj.add(12, 2, 3, 78 ,2 );

            Console.WriteLine("The sum of array " + sum1);

            int sum2 = obj.add(12, 2, 3 ,78,45,87);

            Console.WriteLine("The sum of array " + sum2);
        }
    }
}
