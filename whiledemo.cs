using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class whiledemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 100)
            {
                if (i == 50)
                {
                    break;

                    //continue;
                    
                }
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
