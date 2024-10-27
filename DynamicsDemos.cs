using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class DynamicsDemos
    {
        dynamic show(dynamic x)
        {

            return x;
        
        }

        static void Main(string[] args)
        {
            dynamic obj = new DynamicsDemos();
           // obj.hello();

           dynamic s = obj.show(obj);
            Console.WriteLine(s.GetType());
        }
    }
}
