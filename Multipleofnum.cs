using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day10
{
    class Multipleofnum
    {
        static void print(int n)
        {
            if (n == 0)
                return;
            print(n - 1);
            Console.WriteLine(n*3);
        }
        static void Main(string[] args)
        {
            print(6);
        }
    }
}
