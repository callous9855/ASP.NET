using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class SoNguyenTo
    {
        public void songuyento()
        {
            Console.WriteLine("\n so nguyen to");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int count = 1;
            Console.WriteLine("nhap so bat ky");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("nhap lai so n (n >= 0)");
                n = int.Parse(Console.ReadLine());
            }
            if (n == 1)
                Console.WriteLine("{0} la so nguyen to", n);
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        count++;
                }
                if (count >= 2)
                    Console.WriteLine("{0} khong phai la so nguyen to", n);
                else
                    Console.WriteLine("{0} la so nguyen to", n);
            }
            Console.ReadKey();
        }
        public void tim()
        {
            int count;
            Console.WriteLine("\n kiem tra so nguyen to trong khoan tu 0 den n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap khoang n");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("vui long nhap lai (n > 0)");
                n = int.Parse(Console.ReadLine());
            }
            if (n == 1)
                Console.WriteLine("co 1 so nguyen to trong khoang 0 den 1");
            else
            {
                Console.WriteLine("cac so nguyen to trong day tu 0 den {0} la:", n);
                for (int i = 1; i <= n; i++)
                {
                    count = 1;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                        Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
