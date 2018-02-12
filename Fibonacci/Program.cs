using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int n = int.Parse(Console.ReadLine());
            Fibonacci(0, 1, 1, n);
            Console.ReadLine();
        }

        //tail recursion
        public static void Fibonacci(int a, int b, int counter, int n)
        {
            Console.WriteLine(a);
            if (counter < n) Fibonacci(b, a + b, counter + 1, n);
        }
    }
}
//fib(5)
    //fib(4) + fib(3) [returns 8]
        //fib(3) + fib(2) [returns 5]  |  fib(2) + fib(1) [returns 3]
            //fib(2) + fib(1) [returns 3]  |  fib(1) + fib(0) [returns 2]  |  fib(1) + fib(0) [returns 2]  |  1 [returns 1]