using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYFirstCsharpProject
{
    internal class SentenceDemo
    {

        static void Main(string[] args)
        {
            int countLetter = 0;
            int countDigit = 0;
            int countSymbol = 0;
            int countUpperletter = 0;
            Console.WriteLine("Please enter sentence ");
            string sent = Console.ReadLine();

           
            foreach (Char c in sent)
            {
                if (Char.IsLetter(c))
                {

                    countLetter++;
                }
                if (Char.IsDigit(c))
                {
                    countDigit++;
                }
                if (Char.IsSymbol(c))
                {

                    countSymbol++;
                }
                if (Char.IsUpper(c))
                { 
                countUpperletter++;
                }
            }

            Console.WriteLine("The sentence has no of letteres {0} , number of special letters{1},number of digit {2}",countLetter,countSymbol,countDigit);
        }
    }
}
