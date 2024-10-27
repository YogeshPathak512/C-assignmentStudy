using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Person
    {

        private int empId;    //acces modifier is private only within class 
        private string name;
        private int age;

        public Person ()  //constructor - special method as class name which does not have return type when object is created automatically constrcutor is invoked 
        //without parameter 
        //main usage of constrcuot is initaialize class member variables 
        {

            empId = 0;
            name = "Pinky Shah";
            age = 19;

        }
        public Person(int empId, string name, int age)
        {



            this.empId = empId;
            this.name = name;
            this.age = age;


        }

        public void display()
        {

            Console.WriteLine("Person information "+empId+" Name " +name +" "+ age);
        }
    }
}
