using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class UCLN
    {
        public void UocChung()
        {
            Console.WriteLine("\n uoc chung lon nhat)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int a, b, ucln = 0;
            Console.WriteLine("nhap so dau tien");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai");
            b = int.Parse(Console.ReadLine());
            while (a < 0 || b < 0)
            {
                Console.WriteLine("hai so nhap vao phai lon hon 0");
                Console.WriteLine("nhap lai so dau tien");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap lai so thu hai");
                b = int.Parse(Console.ReadLine());
            }
            int So_nho = (a < b) ? a : b;
            for (int i = So_nho; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    ucln = i;
                    break;
                }
            }
            Console.WriteLine("uoc chung lon nhat cua {0} va {1} la {2}", a, b, ucln);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
