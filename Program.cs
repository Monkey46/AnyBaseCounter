using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyBaseCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What base would you like to count in?");
                int basecount = Int32.Parse(Console.ReadLine());
                Console.WriteLine("And how many times would you like to count?");
                int count = Int32.Parse(Console.ReadLine());
                Console.WriteLine("How many do you what to start with?");
                int numOfDiits = Int32.Parse(Console.ReadLine());
                if (numOfDiits <= 0) numOfDiits = 1;
                Counter newcounter = new Counter(basecount, numOfDiits);
                for (int i = 0; i <= count; i++)
                {
                    Console.WriteLine(newcounter.Number());
                    newcounter.Increment();
                }

                /* Test digit
                Digit dig = new Digit(16);
                Console.WriteLine(dig.GetDigit());
                for (int i = 0; i < 35; i++)
                {
                    Console.WriteLine(dig.GetDigit());
                    dig.Increment();
                }
                */
                /* Char Test
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}", (char)(48+i));
                }
                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine("{0}", (char)(97 + i));
                }
                */
                Console.ReadLine();
            }
        }
    }
}
