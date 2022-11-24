using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class LargeNumber
    {
        public static void Greater()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Number one is greater");
                
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("number two is greater");
            }
            else
            {
                Console.WriteLine("Number three is greater");
            }
        }

    }
}