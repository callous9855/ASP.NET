using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class Tong
    {
        public void dayso()
        {
            Console.WriteLine("\ntong cua day 5 so");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            int n,tong;
            tong = 0;
            for (int i = 1; i<= 5; i++)
            {
                Console.WriteLine("nhap so thu {0}",i);
                n = int.Parse(Console.ReadLine());
                tong = tong + n;
            }
            Console.WriteLine("tong day da cho la: {0}",tong);
            Console.ReadKey();
        }
        public void tongle()
        {
            int tong = 0;
            Console.WriteLine("\n tong so le");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap khoang n");
            Console.WriteLine("nhap so dau");
            int so_dau = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cuoi");
            int so_cuoi = int.Parse(Console.ReadLine());
            while (so_dau > so_cuoi)
            {
                Console.WriteLine("nhap lai so dau (so dau lon hon so cuoi)");
                so_dau = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap lai so cuoi");
                so_cuoi = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("cac so le trong day");
            for (int i = so_dau; i <= so_cuoi; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    tong = tong + i;
                }
            }
            Console.WriteLine("\ntong cua chung la: {0}", tong);
            Console.ReadKey();
        }
        public void tongchan()
        {
            int tong = 0;
            Console.WriteLine("\n tong so le");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap khoang n");
            Console.WriteLine("nhap so dau");
            int so_dau = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so cuoi");
            int so_cuoi = int.Parse(Console.ReadLine());
            while (so_dau > so_cuoi)
            {
                Console.WriteLine("nhap lai so dau (so dau lon hon so cuoi)");
                so_dau = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap lai so cuoi");
                so_cuoi = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("cac so chan trong day");
            for (int i = so_dau; i <= so_cuoi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    tong = tong + i;
                }
            }
            Console.WriteLine("\ntong cua chung la: {0}", tong);
            Console.ReadKey();
        }
    }
}
