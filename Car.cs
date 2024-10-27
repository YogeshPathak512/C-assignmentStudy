using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Car
    {
        private int car_model;
        private string car_name;
        public Car()  //constrcutor

            //construrcto are special method of same name as class name 

            //which implicity invokes when you create object of it 

            //to initialize class member variables 
        {
            car_model = 100;
            car_name = "Benz";
            Console.WriteLine("Default Constrcutor");
        }
        public Car(int car_model ,string car_name )
        {
            this.car_model = car_model;
            this.car_name = car_name;
        }
        static Car()
        {

            Console.WriteLine("static constrcutot ");
        }
        public int Car_model { get => car_model; set => car_model = value; }
        public string Car_name { get { return car_name; } set { car_name = value; } }  //o;d approach 

        public int Car_Price { get; set; }

        public virtual void display()
        {

            Console.WriteLine("Display Car {0} {1} ", Car_model, Car_name);
        }

    }
    }

