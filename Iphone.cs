using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Iphone : Mobile
    {
        public Iphone()
        {
            Console.WriteLine("Iphone !!!");
        }
        public override void storage()
        {
            Console.WriteLine("Storage 128 gb");
            //throw new NotImplementedException();
        }
    }
}
