using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Shape
    {
        public int rad { get; set; }
        public virtual void area (int rad)
        {

            Console.WriteLine("Area " + (2* rad * rad));

        }

    }
}
