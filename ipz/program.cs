using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipz
{
    public class program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n; 
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер числа Фібоначчі: ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);

            Console.WriteLine($"Число Фібоначчі для n = {n} дорівнює {result}");
        }
    }
}
