using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Calstackmechanism
    {

        void m()
        {
            n();


        }

        void n()
        {
            int x = 10;
            int y = 0;
            Console.WriteLine(x/y);
        }


        static void Main(string[] args)
        {

            try
            {
                Calstackmechanism obj = new Calstackmechanism();
                obj.m();
               
            }

            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            Console.WriteLine("End of main");
        }
    }
}
