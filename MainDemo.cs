using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
	internal class MainDemo
	{

		int z;  //instances variable 

		public static int y = 90;  //static variable 


		static int Main()
		{
			int i = 0;  //local variables 

			const string college = "Sophia";
			//   college = "HR";
			Console.WriteLine("Starting with main ");

			Console.WriteLine(college);
			MainDemo obj = new MainDemo();
			Console.WriteLine(i);
			Console.WriteLine(obj.z);

			Console.WriteLine(y);
			return 0;
		}
	}
}
