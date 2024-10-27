using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class outparamval
    {

        public int show(int id, string name, out string country) {

            Console.WriteLine("Id {0} Name {1}",id , name   );
           country="India ";

            return id;

          }

        static void Main(string[] args)
        {
            outparamval obj = new outparamval ();

            string vals;
          int u =   obj.show(1, "Pinky" ,out vals);

            Console.WriteLine(u);
            Console.WriteLine(vals);



        }
        

           
        
        }
    }

