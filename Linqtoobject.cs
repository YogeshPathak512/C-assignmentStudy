using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Linqtoobject
    {
        static void Main(string[] args)
        {
            string[] names = { "Apple", "Banana", "Custard Apple" };
            //            string[] emp = { "Juice", "Milkshakes", "Icecream" };



            Console.WriteLine("Serach");

            var search = from s in names select s;




            foreach (var a in search)
            {
                Console.WriteLine(a);

            }
        }
    }
}
