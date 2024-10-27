using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal  class Square :Shape
    { 

        public int side  { get; set; }


        public void volume (int side )
        {

            Console.WriteLine("Volume Square{0} ", side * side * side  );


        }

        public override void area(int side)   // new tells that this method is new method  shadowing 
        {
             //base keyword calls parent class method in child class 
            Console.WriteLine("Square area " +(side *side ));
            base.area(side);
        }
    }
}
