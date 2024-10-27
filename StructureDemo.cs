using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    struct Book
    {


        public string Name { get; set; }
        public string Title { get; set; }

       public  Book(string Name , string Title)
        {
        this.Name = Name;
            this.Title = Title;
        }


    }

    internal class StructureDemo
    {
        //Book b1;
        static void Main(string[] args)
        {
            
          // b1.Title = "Atomic Habits";
          //  b1.Name = "James Clear ";
            //Console.WriteLine("Details of Book are as follows " +b1.Name+ " " +b1.Title);
            Book b2 = new Book("What to say when you to do self talk" ,"Shepherd ");
            Console.WriteLine("Details of Book are as follows " + b2.Name + " " + b2.Title);

        }
    }
}
