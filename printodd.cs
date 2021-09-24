using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day10
{
    class printodd
    {

        static void printoddnum(int n)
        {
            if (n < 0)
                return;
            else if (n % 2 != 0)
                Console.WriteLine( n );         
            else
            {
                n = n - 1;
                Console.WriteLine(n);
            }
            printoddnum(n - 2);
        }
        static void Main(string[] args)
        {
            printoddnum(9);
        }
    }
}
