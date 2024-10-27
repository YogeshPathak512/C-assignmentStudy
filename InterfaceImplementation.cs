using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class InterfaceImplementation
    {

        static void Main(string[] args)
        {
            Show obj = new Show();
            obj.show();
            IDisplay obj2 = new Show();
            obj2.data();

            IShow obj3 = new Show();
            obj3.data();
        }
    }
}
