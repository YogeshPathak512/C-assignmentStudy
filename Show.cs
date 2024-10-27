using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Show : IShow ,IDisplay
    {
        public void display()
        {
            //  throw new NotImplementedException();

            Console.WriteLine("Coming from Idisplay ");
        }

        public void show()
        {

            Console.WriteLine("Coming from IShow interface method ");
            //throw new NotImplementedException();
        }

        void IShow.data()
        {
            Console.WriteLine("Coming from IShow method !!");
            //throw new NotImplementedException();
        }

        void IDisplay.data()
        {

            Console.WriteLine("Coming from interface IDisplay");
          //  throw new NotImplementedException();
        }

       
    }
}
