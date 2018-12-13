using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class DaoNguoc
    {
        public void nguoc()
        {
            Console.WriteLine("\n in so theo chieu dao nguoc");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so bat ky");
            int a = int.Parse(Console.ReadLine());
            string b = a.ToString();
            for (int i = b.Length - 1; i >= 0; i--)
                Console.Write(b[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
        public void SoDoiXung()
        {
            Console.WriteLine("\n kiem tra so doi xun(so Palindrome)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int a, b, the;
            int So = 0;
            Console.WriteLine("nhap so bat ky");
            a = int.Parse(Console.ReadLine());
            the = a;
            while (a > 0)
            {
                b = a % 10;
                So = (So * 10) + b;
                a = a / 10;
            }
            if (the == So)
                Console.WriteLine("{0} la so Palindrome", the);
            else
                Console.WriteLine("{0} khong la so Palindrome", the);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
