using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class ArrayListDemo
    {

        static void Main(string[] args)
        {
             int [] listcount =  { 1, 2, 3, 4};
            ArrayList listfruits = new ArrayList();
            Console.WriteLine(listfruits.Capacity);
            listfruits.Add(12);
           // listfruits.Add("Pinky");
            listfruits.AddRange(listcount);
           // listfruits.Add("Pinky"); 
            Console.WriteLine("Capacity afeter adding "+listfruits.Capacity);
            foreach (Object o in listfruits)
            {

                Console.WriteLine(o);
            }
            listfruits.Add(12);
            listfruits.Add("Pinky");
            listfruits.AddRange(listcount);
            listfruits.Add("Pinky");
            Console.WriteLine(listfruits.Capacity);
            Console.WriteLine("Seraching for element ");
           // listfruits.Sort();  ///sorts data based on string 
            foreach (Object o in listfruits)
            {

                Console.WriteLine(o);
            }
            Console.WriteLine("Serach"+   listfruits.BinarySearch(12));
            Console.WriteLine(listfruits.Contains("Pinky"));
            Console.WriteLine("Count of element "+listfruits.Count);

            listfruits.Insert(4, "Tejas");
            Console.WriteLine("Iterating element after adding");

            listfruits.RemoveAt(3);
            listfruits.Remove("Pinky");
            foreach (Object o in listfruits)
            {

                Console.WriteLine(o);
            }
            IEnumerator enumerator = listfruits.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
           
        }
    }
}
