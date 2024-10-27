using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class switchdemo
    {

        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            switch (input)   //if else if 
            {
                case "Mon":
                    Console.WriteLine("Monday is first day of week ");
                    break;
                case "Tues":
                    Console.WriteLine("Tuesday is second day of week ");
                    break;
                
                default:
                    Console.WriteLine("Not an day  ");
                    break;


            }
        }
    }
}
