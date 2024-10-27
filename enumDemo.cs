using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{  public enum weekdays
    {
        Mon,
        Tues,
        Wed,
        Thurs,
        Fri



    }
    internal class enumDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(weekdays.Wed);

            int day = (int)(weekdays.Thurs);
            Console.WriteLine(day);
        }
    }
}
