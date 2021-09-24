using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day10
{
    class sum_naturalnum
    {

        static int sum(int n)
        {
            if (n == 0)
                return n;
            return n + sum(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sum(5));
        }

    }
}
