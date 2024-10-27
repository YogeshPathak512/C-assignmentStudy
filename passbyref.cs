using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class passbyref
    {
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Pinky";
        }

        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Shah";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
    }
}
