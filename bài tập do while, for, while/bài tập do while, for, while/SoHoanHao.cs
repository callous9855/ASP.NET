using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class SoHoanHao
    {
        public void hoanhao()
        {
            Console.WriteLine("\n so hoan hao");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int tong = 0;
            Console.WriteLine("nhap so bat ky");
            int So = int.Parse(Console.ReadLine());
            while (So < 0)
            {
                Console.WriteLine("nhap lai so (n > 0)");
                So = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < So; i++)
            {
                if (So % i == 0)
                    tong = tong + i;
            }
            if (tong == So)
                Console.WriteLine(So + " la so hoan hao");
            else
                Console.WriteLine(So + " khong la so hoan hao");
            Console.ReadKey();
        }
        public void daysohoanhao()
        {
            Console.WriteLine("\n so hoan hao trong day tu 0 den n voi n nhap tu ban phim");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int i = 1;
            int tong = 0;
            Console.WriteLine("nhap so bat ky");
            int So = int.Parse(Console.ReadLine());
            while (So < 0)
            {
                Console.WriteLine("nhap lai so (n > 0)");
                So = int.Parse(Console.ReadLine());
            }
            for (int n = 1; n < So; n++)
            {
                i = 1;
                tong = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        tong = tong + i;
                    i++;
                }
                if (tong == n)
                    Console.WriteLine(n + " ");
            }
            Console.ReadKey();
        }
    }
}
