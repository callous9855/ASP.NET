using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class BCNN
    {
        public void BoiChung()
        {
            Console.WriteLine("\n boi chung nho nhat)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int a, b, phu, bcnn = 0;
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
            int So_lon = (a > b) ? a : b;
            phu = a * b;
            for (int i = phu; i >= So_lon; i--)
            {
                if (i % a == 0 && i % b == 0)
                    bcnn = i;
            }
            Console.WriteLine("boi chung nho nhat cua {0} va {1} la {2}", a, b, bcnn);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
