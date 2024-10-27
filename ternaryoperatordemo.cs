using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ternaryoperatordemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value of age ");
            int age = Convert.ToInt32(Console.ReadLine());
            string result =age > 18 ? "Eligible to vote " : "Not eigible to vote ";
            Console.WriteLine(result);
        }
    }
}
