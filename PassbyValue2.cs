using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class PassbyValue2
    {
        static void ChangeValue(int i)
        {
            i = 200;

            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            int i = 100;

            Console.WriteLine(i);  // value=100

            ChangeValue(i);

            Console.WriteLine(i);
        }
    }
}
