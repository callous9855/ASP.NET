using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class HienThiNgay
    {
        public void ngay()
        {
            int so;
            Console.WriteLine("hien thi ngay");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so bat ky tu 1 den 7");
            so = int.Parse(Console.ReadLine());
            switch (so)
            {
                case 1:
                    Console.WriteLine("hom nay la thu hai");
                    break;
                case 2:
                    Console.WriteLine("hom nay la thu ba");
                    break;
                case 3:
                    Console.WriteLine("hom nay la thu tu");
                    break;
                case 4:
                    Console.WriteLine("hom nay la thu nam");
                    break;
                case 5:
                    Console.WriteLine("hom nay la thu sau");
                    break;
                case 6:
                    Console.WriteLine("hom nay la thu bay");
                    break;
                case 7:
                    Console.WriteLine("hom nay la chu nhat");
                    break;
                default:
                    Console.WriteLine("so ban nhap khong hop le");
                    break;
            }
            Console.ReadKey();
        }
    }
}
