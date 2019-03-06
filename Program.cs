using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_Ticher
{
    class Program
    {
        static void Main(string[] args)
        {
            long nr = long.Parse(Console.ReadLine());
            Console.WriteLine(fibon(nr));
        }

        static long fibon (long nr)
        {
            long N1 = 0;
            long N2 = 0;
            if (nr <= 2)
                return 1;
            N1 = fibon(nr - 1);
            N2 = fibon(nr - 2);
             long sum = N1 + N2;
             return sum;
        }
    }
}

 /*static void Main(string[] args)
        {
            long nr = long.Parse(Console.ReadLine());
            Console.WriteLine(fibon(nr));
        }

        static long fibon (long nr)
        {
            long N1 = 0;
            long N2 = 0;
            if (nr <= 2)
                return 1;
            N1 = fibon(nr - 1);
            N2 = fibon(nr - 2);
             long sum = N1 + N2;
             return sum;
        }*/
