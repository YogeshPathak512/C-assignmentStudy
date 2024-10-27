using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ObjectInitalizer
    {

        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.age = 21;
            c.name = "Mickey"; //traditional approach 
            Cat c1 = new Cat { name = "Mouse", age = 21 };  //object iniatilzer 
            Console.WriteLine(c1.age);
            Console.WriteLine(c1.name);
            Cat c3 = new Cat { name = "Mouse1", age = 121 };

            //creating list of Cat object in list 
            List<Cat> c2 = new List<Cat>();  //old approach to add elements in list 
            c2.Add(c1);
            c2.Add(c3);

            foreach ( var d in c2)
            {

                Console.WriteLine("The Cat information" +d.name +" " +d.age);

            }

            //collection Initializer 
            Console.WriteLine("Collection Initalizer");
            List<Cat> lscat = new List<Cat>() { new Cat { name="CATTY" ,age=11},
            new Cat { name="Pussy" ,age=12}};
            foreach (var d in lscat)
            {

                Console.WriteLine("The Cat information" + d.name + " " + d.age);

            }

        }
    }
}
