using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class UseCustomExceptiondemo
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter age ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                { throw new CustomException("Age less than 18 "); }

                Console.WriteLine("Valid age to vote ");
            }
            catch (CustomException ex)
            { Console.WriteLine(ex.message); }
        }
    }
}
