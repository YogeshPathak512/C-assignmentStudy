using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class Datatypedemo
    {
        static void Main(string[] args)
        {

            
            byte b = 10;
            sbyte s = -128;
            short s1 =17387;
            ushort s2 = 17877;

            int i = 565675;
            uint u = 878778778;

            long hh = -67676767676;
            ulong h1 = 6767676732;
            float f = 323E+3f;  //323*10*10*10
            Console.WriteLine(f);
            float f1 = 1.7f;

            float f3 = 78888E-6F;  //0.078888
            Console.WriteLine(f3);
            double d = 8.7777E-3d;

            Console.WriteLine(d);

            double d1 = 0.12e2;

            Console.WriteLine(d1);
           
            char[] arr = { 'p', 'i', 'n' ,'k' ,'y'};

            String obj = new String(arr,1,3);
            Console.WriteLine(obj.GetHashCode());
            string s9 = "Pinky";

            Console.WriteLine(s9.GetHashCode());
            s9 = s9 + "Shah";

            Console.WriteLine(s9);

            Console.WriteLine(s9.GetHashCode());
            String s10 = "Shah";  //creating string variable with String and string is same 
            Console.WriteLine("String Builder Demo");
            //string is immutable stringbuilder is mutable 
            StringBuilder sbr = new StringBuilder("Pinky");
            Console.WriteLine(sbr.GetHashCode());
            sbr.Append("Shah");

            Console.WriteLine(sbr.GetHashCode());


            string multiline = "My Class \n" + "my new line\n" + "Hello this is multiline ";
            Console.WriteLine(multiline);

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

        }
    }
}
