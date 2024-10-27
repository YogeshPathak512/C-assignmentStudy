using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class airthemetaicdemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator to perform operations + ,- * /  ");
            char z = Convert.ToChar(Console.ReadLine());    
            switch (z)   //if else if 
            {
                case '+':
                    Console.WriteLine(x + y);
                     break;
                case '-':
                    Console.WriteLine(x -y);
                    break;
                case '/':
                    Console.WriteLine(x / y);
                    break;
                case '*':
                    Console.WriteLine(x * y);
                    break;
                default:
                    Console.WriteLine("Not an operator ");
                    break;


            }
        }
    }
}
