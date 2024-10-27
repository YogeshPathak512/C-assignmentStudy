using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class HCFdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");

          int   num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int min = num1<num2? num1 : num2;
            Console.WriteLine(min);
            int HCF = 0;
            int max =num1>num2 ? num1 : num2;
            for (int i = 1; i <= min; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    HCF = i;
                }
            }
            int LCM = 0;
            for (int i = 1; i <= max; i++)
            {
                if (num1 % i == 0  || num2 % i == 0)
                {
                    LCM= i;
                }
            }
            Console.WriteLine("HCF is " +HCF);

            Console.WriteLine("LCM" +LCM);
        }
    }
}
