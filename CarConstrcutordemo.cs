using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class CarConstrcutordemo
    {
        static void Main(string[] args)
        {

            Car car = new Car();//call default constrcutor 
         
           // car.display();

            Car cars = new Car(21 ,"Audi");
           // cars.display();

            SpecialCar obj = new SpecialCar();
           // obj.display();

          Car objc = new SpecialCar ();//Parent class refrence and object of chils class
            objc.display();

            Console.Read();
        }
    }
}
