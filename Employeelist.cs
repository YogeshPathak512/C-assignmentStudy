using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Employeelist
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  //creation of object of class 
            employee.EmpId = 12;
            employee.EmpName = "Pinky Shah";
            employee.Designation = "Head talent Developement";
            employee.managername = "XXXX";
            employee.display();
            Console.WriteLine("Please enter number of employees");
            int x = Convert.ToInt32(Console.ReadLine());
            Employee[] emplist = new Employee[x];
           
            for (int i = 0; i < emplist.Length; i++)
            {
                Console.WriteLine("Enter empId");
                Employee e = new Employee();
                e.EmpId= Convert.ToInt32(Console.ReadLine());
                e.EmpName = Console.ReadLine();
                e.Designation = Console.ReadLine();

                emplist[i] = e;
            }

            foreach (Employee emp in emplist)
            {

                Console.WriteLine("Employee List : Employee Id" +emp.EmpId +"Employee Name" +emp.EmpName +"Designation :" +emp.Designation);
            
            }
           
        }
    }
}
