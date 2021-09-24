using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch34_day10
{
    class armstrong
    {
        //n=1234         1    2    3   4
        static void printdig(int n)
        {
            if (n == 0)
                return;
            printdig(n / 10);
            Console.WriteLine(n%10);

        }
        static int count(int n)
        {
            if (n == 0)
                return n;
            return 1 + count(n / 10);
        }
        static int armstnum(int n)
        {
            if (n == 0)
                return n;
            return (int)Math.Pow(n%10,3) + armstnum(n/10);
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n = ");
            n = int.Parse(Console.ReadLine());
            if(n==armstnum(n))
                Console.WriteLine(n + " armstrong ");
            else
                Console.WriteLine(n + " not armstrong ");

        }
    }
}
