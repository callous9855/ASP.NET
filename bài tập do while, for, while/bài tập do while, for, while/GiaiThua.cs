using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class GiaiThua
    {
        public void giaithua()
        {
            Console.WriteLine("\n giai thua cua mot so");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int Giai_thua = 1;
            Console.WriteLine("nhap so bat ki");
            int n = int.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("nhap lai so (n >= 1)");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
                Giai_thua = Giai_thua * i;
            Console.WriteLine("{0} giai thua la: {1}", n, Giai_thua);
            Console.ReadKey();
        }
    }
}
