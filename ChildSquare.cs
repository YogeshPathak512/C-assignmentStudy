using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ChildSquare:Square 
    {

        public int id { get; set; }

        public void surfacearea()
        {

            Console.WriteLine("Coming from ChildQuare ");
        }
    }
}
