using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class Swap
    {
        public static void Number()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping num1 = {0} and num2 = {1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping num1 = {0} and num2 = {0}", num1, num2);
            Console.ReadKey();
        }
    }
}
