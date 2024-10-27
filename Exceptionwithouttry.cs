using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Exceptionwithouttry
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter two nymbers ");
                int num = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num / num2);
            }
            catch (DivideByZeroException d)
            { Console.WriteLine(d.Message); }
            catch (Exception ex)
            { //Console.WriteLine(ex.ToString());

                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message );
                Console.WriteLine("Inner "+ex.InnerException);
            }

            
            finally { Console.WriteLine("End of main"); }

                
        }
    }
}
