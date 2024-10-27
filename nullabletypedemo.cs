using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class nullabletypedemo
    {
        static void Main(string[] args)
  
            {


            int? m = null;
            //    Nullable<int> i = null;
            //int? i = null;
            int ?i = null;
                if (i.HasValue)
                    Console.WriteLine(i.Value); // or Console.WriteLine(i)
                else
                    Console.WriteLine("Null");
            }
        }
    
}
