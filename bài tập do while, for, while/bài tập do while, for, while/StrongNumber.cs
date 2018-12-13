using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class StrongNumber
    {
        public void SN()
        {
            Console.WriteLine("\n strong number");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("strong number la so co tong giai thua cac chu so bang chinh so ban dau");
            int a, b, phu, tong = 0, gt = 1;
            Console.WriteLine("nhap so bat ky");
            a = int.Parse(Console.ReadLine());
            phu = a;
            while (a < 0)
            {
                Console.WriteLine("so nhap vao phai lon hon 0");
                Console.WriteLine("nhap lai so");
                a = int.Parse(Console.ReadLine());

            }
            while (a > 0)
            {
                b = a % 10;
                gt = 1;
                for (int i = 1; i <= b; i++)
                {
                    gt = gt * i;
                }
                tong = tong + gt;
                a = a / 10;
            }
            if (tong == a)
                Console.WriteLine("{0} la strong number", a);
            else
                Console.WriteLine("{0} khong phai la strong number", a);
            Console.WriteLine(tong);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
