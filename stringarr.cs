using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class stringarr
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number to be entered ");
            int x = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[x];

            for (int i = 0;i<arr.Length;i++)
            {

                arr[i] = Console.ReadLine();

            }

            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }

        }
    }
}
