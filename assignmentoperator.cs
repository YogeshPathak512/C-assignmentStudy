using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class assignmentoperator
    {

        static void Main(string[] args)
        {
            int x = 10;  // x is assinged value of 10 

            Console.WriteLine(x == 10); //

            x += 20; /// x= x+20
            x -= 10;
            Console.WriteLine(x);

            //comparison operator 

            int a = 20, b = 30;
            Console.WriteLine(a>b);  //false
            Console.WriteLine(a >= b);//false
            Console.WriteLine(a < b); //true
            Console.WriteLine(a == b);//fasle
            Console.WriteLine(a!=b);


        }
    }
}
