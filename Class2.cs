using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal abstract  class Mobile
    {

        public Mobile()
        {
            Console.WriteLine("Constructor calling");
        }
     public abstract   void storage();

        public void calling()
        {
            Console.WriteLine("Calling Method ");
        }

    }
}
