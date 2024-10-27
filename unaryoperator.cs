using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class unaryoperator
    {
        static void Main(string[] args)
        {

            //x++  Means x = x+1
            //--x means x=x-1
            int x = 10;
            x++;
            Console.WriteLine(x);
            int y = 20;
            --y;
            Console.WriteLine(y);

            Console.WriteLine(++x - --y);
         


        }
    }
}
