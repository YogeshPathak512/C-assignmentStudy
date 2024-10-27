using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class statics
    {

        static void Main(string[] args)
        {
            staticmethoddemo.show();

            staticmethoddemo obj = new staticmethoddemo ();
            obj.instancemethod();

            int ans =obj.add(12, 23);

            Console.WriteLine("Answer is "+ans );
        }
    }
}
