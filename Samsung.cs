using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Samsung : Mobile
    {

        public Samsung()
        {
            Console.WriteLine("Samsung!!!!");
        }
        public override void storage()
        {
            Console.WriteLine("Storage Samsung 256 gb ");
          //  throw new NotImplementedException();
        }
    }
}
