using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal  static  class StudentStatic
    {

        public static void displaySpecial(this Student obj)
        {


            Console.WriteLine("Coming from Exntesnion method ");
        }
    }
}
