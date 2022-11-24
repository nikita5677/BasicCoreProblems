using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    class FlipCoin
    {
        public static Tuple<int, int> count_ht(char s, int N)
        {
            // Check if initially all the 
            // coins are facing towards head 
            Tuple<int, int> p = Tuple.Create(0, 0);

            if (s == 'H')
            {
                p = Tuple.Create((int)Math.Floor(N / 2.0),
                                 (int)Math.Ceiling(N / 2.0));
            }
            // Check if initially all the coins 
            // are facing towards tail 
            else if (s == 'T')
            {
                p = Tuple.Create((int)Math.Ceiling(N / 2.0),
                                 (int)Math.Floor(N / 2.0));
            }
            return p;
        }
        // Driver Code
        public static void Coin()
        {
            char C = 'H';
            int N = 5;
            Tuple<int, int> p = count_ht(C, N);

            Console.WriteLine("Head = " + p.Item1);
            Console.WriteLine("Tail = " + p.Item2);
        }

    }
}