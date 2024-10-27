using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Vardemo
    {

        public int add (int x , int z )
        { return x + z; }   
        static void Main(string[] args)
        {

            var pinky = "DDD";
            var i = 10;  //declaring variable with var that only we need to initailze variable 
            i = 12;
           
            Console.WriteLine(i.GetType());
            // i = "SSSS";  i once initilaize cannot change its type 


            var s = "Pinky Shah";
            Console.WriteLine(s.GetType()); 
            Console.WriteLine(s);

            var e = new int[] { 21, 2, 3, 5 };
            Console.WriteLine(e.GetType());
            Vardemo obj = new Vardemo();
            var values = obj.show();

            foreach (var v in values)
            {
                Console.WriteLine(v);
            }
            var dd = obj.add(12, 23);
            Console.WriteLine(dd);
        }

        public List<int> show ()
        {


            return new List<int> { 21, 2, 3, 5 };
        }
    }
}
