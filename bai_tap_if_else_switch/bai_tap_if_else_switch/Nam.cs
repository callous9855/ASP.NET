using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class Nam
    {
        int a;
        public void NamNhuan()
        {
            Console.WriteLine("kiem tra nam nhuan");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập năm
            Console.Write("nhap nam ");
            a = int.Parse(Console.ReadLine());
            Console.Write(a);
            //điều kiện năm nhuận
            if ((a % 100 == 0 && a % 4 == 0)||(a % 4 == 0))
                Console.WriteLine("\n" + a + " la nam nhuan");
            else
                Console.WriteLine("\n" + a + " khong phai nam nhuan");
            Console.ReadKey();
        }
    }
}
