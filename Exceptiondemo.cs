using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Exceptiondemo
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter two numberrs ");
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x / y);
            }
            
            catch (DivideByZeroException ex)
            { Console.WriteLine("Thats bad trying to divide by zero"); }
            catch (Exception e) { Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
           
            finally
            {
                Console.WriteLine("End of Main");
            }

        }
    }
}
