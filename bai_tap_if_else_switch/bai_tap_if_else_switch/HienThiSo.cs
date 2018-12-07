using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class HienThiSo
    {
        public void So()
        {
            int so;
            Console.WriteLine("hien thi so tuong ung");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap so bat ky tu 1 den 7");
            so = int.Parse(Console.ReadLine());
            switch (so)
            {
                case 1:
                    Console.WriteLine("mot");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine("bon");
                    break;
                case 5:
                    Console.WriteLine("nam");
                    break;
                case 6:
                    Console.WriteLine("sau");
                    break;
                case 7:
                    Console.WriteLine("bay");
                    break;
                case 8:
                    Console.WriteLine("tam");
                    break;
                case 9:
                    Console.WriteLine("chin");
                    break;
                default:
                    Console.WriteLine("so ban nhap khong hop le");
                    break;
            }
            Console.ReadKey();
        }
    }
}
