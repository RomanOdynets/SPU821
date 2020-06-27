using HW_20_06.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_20_06
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter + - / * and nums to get result");
                return;
            }

            int[] incomin = new int[args.Length-1];
            for (int i = 0; i < args.Length-1; i++) int.TryParse(args[i+1], out incomin[i]);

            switch (args[0])
            {
                case "+":
                    Console.WriteLine(M.Add(incomin));
                    break;
                case "-":
                    Console.WriteLine(M.Tru(incomin));
                    break;
                case "*":
                    Console.WriteLine(M.Mul(incomin));
                    break;
                case "/":
                    Console.WriteLine(M.Div(incomin));
                    break;
            }

            
        }
    }
}
