using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ThrowDemo
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter age ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    //Console.WriteLine("age less than 18");
                    throw new Exception("Age less than 18 "); //Raise exception 
                }
                Console.WriteLine("You are eligible to vote ");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            finally
            {
                Console.WriteLine("End of main");
            }
                
        }

    }
}
