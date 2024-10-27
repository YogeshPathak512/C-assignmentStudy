using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Employee
    {
        private int empId;
        string empName;
        string designation;

        public string managername { get; set; }  //autoimplemented property 

        public int EmpId { get => empId; set => empId = value; }  //property 

        public string EmpName    //read and write only properties if only get then its read only if only set then only write properties 
        {
            get { return empName; }
            set { empName = value; }
}
        public string Designation { get { return designation; } set { designation = value; } }

        public void display ()
        {
            Console.WriteLine("Details of Employee ID {0} Name {1} and disgnation {2}" ,EmpId ,empName, designation );

        }
    }
}
