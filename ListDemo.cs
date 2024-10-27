using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ListDemo
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("1");
            lst.Add("2");
            lst.Add("Pinky");
           // lst.Add(12);  cant add int in list of type string type safe 

            IEnumerator<string> lst2 = lst.GetEnumerator();
            while (lst2.MoveNext())
            {

                Console.WriteLine(lst2.Current);
            }

            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
           
            
        }
    }
}
