using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class EvenOdd
    {
        public static void Evodd()
        {
            //take input
            Console.Write("Enter the number = ");
            int n = Convert.ToInt32(Console.ReadLine());

            //check if n is even or odd
            if (n % 2 == 0)
                Console.WriteLine(n + " is even");
            else
                Console.WriteLine(n + " is odd");

            // wait for user to press any key
            Console.ReadKey();
        }
    }
}
