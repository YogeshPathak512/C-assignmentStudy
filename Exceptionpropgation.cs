using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Exceptionpropgation
    {

       

        void b ()
        {
            int num = 1;
            int num2 = 0;
            Console.WriteLine(num/num2);
        }

        void z()
        {
            try
            {
                b();
            }
        catch (Exception ex)

            { Console.WriteLine(ex.Message); }
        }

        static void Main(string[] args)
        {
            Exceptionpropgation obj = new Exceptionpropgation();
            obj.z();
        }
    }
}
