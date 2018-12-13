using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class BangCuuChuong
    {
        public void nhan()
        {
            Console.WriteLine("\n Bang cuu chuong");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            for (int i = 1; i<= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
                }
                Console.WriteLine();
            }
        }
    }
}
