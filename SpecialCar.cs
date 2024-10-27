using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class SpecialCar:Car
    {
        private string systemusic;

        public SpecialCar():base()
        {
            systemusic = "spotify";
        }
        public SpecialCar(string systemusic , int car_model , string car_name ):base (car_model,car_name)
        {
         this.systemusic = systemusic;
        }

        public new void display()
        {//new makes this method as new method 
            base.display();
            Console.WriteLine("Emp {0} {1}{2} ", Car_model,Car_name,Systemusic);
        }
        public string Systemusic { get => systemusic; set => systemusic = value; }
    }
}
