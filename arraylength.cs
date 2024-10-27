using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class arraylength
    {

        static void Main(string[] args)
        {
            int [] arr = { 1, 2, 3 };
            int size = 0;
            foreach (int i in arr)
            {
                
                Console.WriteLine(i);
                size++;
            }
            Console.WriteLine("The size of array "+size);
          int c =   Array.Find(arr,x=>x.Equals(2));

            Array.Sort(arr);
           Array.Resize(ref arr, 10);

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr);
            Console.WriteLine("Presen " +c);

        }

        
    }
}
