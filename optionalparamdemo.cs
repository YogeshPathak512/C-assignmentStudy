using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class optionalparamdemo
    {

        public int multiplication(int x, int y, int z = 9)
        {

            return x * y * z;
        
        }

        static void Main(string[] args)
        {

            optionalparamdemo obj = new optionalparamdemo();

            int val1 =obj.multiplication(1 ,2 ,3);

            Console.WriteLine(val1);

            int val2 =obj.multiplication(1 ,2 );
            Console.WriteLine(val2);

        }
    }
}
