using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class BangNhan
    {
        public void nhan()
        {
            Console.WriteLine("\n in bang nhan cua mot so bat ky");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so bat ky");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("vui long nhap lai (n > 0)");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
            Console.ReadKey();
        }
    }
}
