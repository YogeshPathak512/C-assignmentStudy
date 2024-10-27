using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Null_calesing
    {

        static void Main(string[] args)
        {
            List<int> numbers = null;
            int? a = null;  

           /* (numbers ??= new List<int>()).Add(5);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5

            numbers.Add(a ??= 0);
            Console.WriteLine(string.Join(" ", numbers));  // output: 5 0
           */ Console.WriteLine(a);  // output: 0
        }
    }
}
