using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class overloadingdemo
    {
        void add ( int x   , int y )
        {

            Console.WriteLine(x+y);
        }

        void add(string x, string y)
        { Console.WriteLine(x+y); }

        void add(int x, int y , int z )
        {
            Console.WriteLine(x+y +z);
        }

        void add(int x, string y)
        {

            Console.WriteLine (x+y);
        }

        void add(string x, int y)
        {
            Console.WriteLine(x + y);
        }


        static void Main(string[] args)
        {
            overloadingdemo ob = new overloadingdemo();
            ob.add(12, 23);
            ob.add(12, 23, 78);
            ob.add(12, " Pinky");
            ob.add("Pinky Shah", 12);
            ob.add("Pinky", " Shah");
        }
    }
}
