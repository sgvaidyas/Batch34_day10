using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day10
{
    class Countdig
    {
        static int count(int n)
        {
            if (n == 0)
                return n;
            return 1+count(n / 10);
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("count of "+ n+ " = " + count(n));
        }
    }
}
