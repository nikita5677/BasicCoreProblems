using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class LeapYear
    {
        public static void Year()
        {
            Console.WriteLine("Enter  a year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(" {0} is a Leap Year");
            }
            else
            {
                Console.WriteLine(" {0} is not a Leap Year");
            }
        }
    }
}