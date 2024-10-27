using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class areaofcircle
    {
        static void Main(string[] args)


        {

            Console.WriteLine(MainDemo.y);
            //variables can change value but datatype should match the requirement 
            int num=100;
            num=200;
            Console.WriteLine(num);
            const double pi = 3.14; //constant variable 
            

            double raduis = Convert.ToDouble(Console.ReadLine());
            double area = pi * raduis * raduis;
            Console.WriteLine("Area of circle "+area);

        }
    }
}
