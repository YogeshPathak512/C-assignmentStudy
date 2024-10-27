using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class constrcutordemo
    {
        static void Main(string[] args)
        {



            Person p = new Person();
            p.display();
            Person p1 = new Person(111, "AAAAA" ,66);
            p1.display();
            Console.Read();
        }
        
    }
}
