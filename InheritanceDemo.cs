using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class InheritanceDemo
    {
        static void Main(string[] args)
        {
            /*Shape obj = new Shape();  //creating object of parent /base class 
            obj.rad = 21;
            obj.area(obj.rad);
           Square obj1 = new Square (); //creating child class obj 
            obj1.rad = 10;
            obj1.area(obj1.rad);

            obj1.side = 21;
            obj1.volume(obj1.side);*/

            Shape obj2 = new Square(); //poymorphic refrenece 
            obj2.area(2);

            /*ChildSquare obj3 = new ChildSquare ();
            obj3.rad = 21;
            obj3.area(21);

            */
            
        }
    }
}
