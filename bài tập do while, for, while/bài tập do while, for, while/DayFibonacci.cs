using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class DayFibonacci
    {
        public void Fibonacci()
        {
            Console.WriteLine("\n so Fibonacci");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int a = 0;
            int b = 1;
            int ex;
            Console.WriteLine("nhap do dai day");
            int dai = int.Parse(Console.ReadLine());
            while (dai < 0)
            {
                Console.WriteLine("nhap lai so");
                dai = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= dai; i++)
            {
                ex = a + b;
                Console.Write(" {0} ", ex);
                a = b;
                b = ex;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
