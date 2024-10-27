using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ifedemos
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter age and gender");

            int age = Convert.ToInt32(Console.ReadLine());
            string gender = Console.ReadLine();
            if (age > 18) 
            {

                if (gender == "Male")
                {
                    Console.WriteLine("He is eligible to vote ");
                }
                else { Console.WriteLine("She is eligible to vote "); 
                }

            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }
    }
    }

