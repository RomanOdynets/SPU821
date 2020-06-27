using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncronus_27_06
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int x = await FactorialAsync(10);
            Console.WriteLine("Enter num: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа {n} = {n*n}");
            Console.ReadLine();
        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static async Task<int> FactorialAsync(int n)
        {
            Console.WriteLine("Async Started");
            return await Task.Run(() => Factorial(n));
        }
    }
}
