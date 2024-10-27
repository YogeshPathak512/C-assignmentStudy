using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class NameParameterdemo
    {

        public void showData(int id , string designation, string name)
        {

            Console.WriteLine("The data is as follows ID :{0} , Emp Name {1} , and Designation {1} " ,id ,name , designation );
        }

        static void Main(string[] args)
        {
            NameParameterdemo obj = new NameParameterdemo ();
            obj.showData(1, "Manager", "Pinky Shah"); //traditional way 

            obj.showData(name:"Pinky " , designation:"Manager" , id:1);  // Name argument 




        }
    }
}
