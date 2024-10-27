using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class BoxingDemo
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i; //Boxing  conversion of Value type to refernce 
            Console.WriteLine(o);
            int j = (int)o;//Unboxing Conversion of reference into value type   (Casting ) 
            Console.WriteLine(j+j);

            float h = 1.2f;
            int k1 = (int)h;
            Console.WriteLine(k1);   //what will the ouput 

            //int k2 = 11111;
            //float k3 = k2;
            //Console.WriteLine(k3);
            //Console.WriteLine(k3);
            //float s = 2222.2222f;
            //Console.WriteLine(  "Float value in integer ");
            //int l =(int) s;
            //Console.WriteLine(l);


        }
    }
}
