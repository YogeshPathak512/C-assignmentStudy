using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class refdemocs
    {

        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x= y;
            y= temp;

            
            Console.WriteLine(" Values {0} {1}", x , y ); }
        static void Main(string[] args)
        {
            refdemocs obj = new refdemocs();

            int x = 10;
            int y = 11;
            Console.WriteLine("befor calling method ");
            Console.WriteLine(x + " " + y);

            obj.swap(ref x,ref y);
            Console.WriteLine("After calling method ");
            Console.WriteLine(x +" "+ y );

        }
    }
}
