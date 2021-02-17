using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10이하의 소수 : {0}, {1}, {2}, {3} ", 2, 3, 5, 7);

            string primes;
            primes = string.Format("10이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
