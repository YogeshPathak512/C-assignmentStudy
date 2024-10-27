using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class staticmethoddemo
    {
        public void instancemethod() { Console.WriteLine("instance method !!!"); }


        public int add( int x, int y)   //int x int y are formal paramter  int return type 
        {

            return x + y;
        }
        public static void show() { Console.WriteLine("static method !!!"); }

        static void Main(string[] args)
        { 

            staticmethoddemo  obj = new staticmethoddemo ();
             obj.instancemethod();
           
            staticmethoddemo.show();
            obj.add(12, 23);
           // Console.WriteLine(obj.add(12, 23));
        }
    }
}
