using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class Factors
    {
        public static void Number()
        {
            int i;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors are the: ");
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}