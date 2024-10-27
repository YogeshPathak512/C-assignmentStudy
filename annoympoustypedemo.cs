using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class annoympoustypedemo
    {

        static void Main(string[] args)
        {
            var emp = new { id = 12, name= "Pinky Shah" };

            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);

        }
    }
}
