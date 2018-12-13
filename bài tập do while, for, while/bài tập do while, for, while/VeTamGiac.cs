using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class VeTamGiac
    {
        public void tamgiacsao()
        {
            Console.WriteLine("\n ve tam giac sao");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so hang tam giac");
            int hang = int.Parse(Console.ReadLine());
            while (hang < 1)
            {
                Console.WriteLine("nhap lai so hang (n >= 1)");
                hang = int.Parse(Console.ReadLine());
            }
            for (int i = hang; i >= 1; i--)
            {
                for (int cot = i; cot >= 1; cot--)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public void tamgiacso()
        {
            Console.WriteLine("\n ve tam gaic so");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so hang tam giac");
            int hang = int.Parse(Console.ReadLine());
            while (hang < 1)
            {
                Console.WriteLine("nhap lai so hang (n >= 1)");
                hang = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= hang; i++)
            {
                for (int cot = 1; cot <= i; cot++)
                    Console.Write(cot);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public void tamgiacso2()
        {
            Console.WriteLine("\n ve tam giac so");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so hang tam giac");
            int hang = int.Parse(Console.ReadLine());
            while (hang < 1)
            {
                Console.WriteLine("nhap lai so hang (n >= 1)");
                hang = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= hang; i++)
            {
                for (int cot = 1; cot <= i; cot++)
                    Console.Write(i);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public void tamgiacso3()
        {
            Console.WriteLine("\n tam giac so");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int count = 1;
            Console.WriteLine("nhap so hang tam giac");
            int hang = int.Parse(Console.ReadLine());
            while (hang < 1)
            {
                Console.WriteLine("nhap lai so hang (n >= 1)");
                hang = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= hang; i++)
            {
                for (int cot = 1; cot <= i; cot++)
                    Console.Write(count++ + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
