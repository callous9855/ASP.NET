using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class TongDaySo
    {
        public void day1()
        {
            Console.WriteLine("\n tong day so: 1/1 + 1/2 + 1/3 + 1/4 + ...ky");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            float tong = 0;
            Console.WriteLine("nhap so phan tu");
            int So_Phan_tu = int.Parse(Console.ReadLine());
            while (So_Phan_tu < 0)
            {
                Console.WriteLine("nhap so lai phan tu");
                So_Phan_tu = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= So_Phan_tu; i++)
            {
                tong = tong + (1 / (float)i);
            }
            Console.WriteLine("tong bang {0}", tong);
            Console.ReadKey();
        }
        public void day2()
        {
            Console.WriteLine("\n tinh tong day so 9 + 99 + 999 + ...");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int tong = 0;
            int n = 1;
            Console.WriteLine("nhap so phan tu");
            int So_Phan_tu = int.Parse(Console.ReadLine());
            while (So_Phan_tu < 0)
            {
                Console.WriteLine("nhap so lai phan tu");
                So_Phan_tu = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= So_Phan_tu; i++)
            {
                tong = tong + (9 * n);
                n += 10;
            }
            Console.WriteLine("tong cua day la: " + tong);
            Console.ReadKey();
        }
    }
}
