using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class CheckAmDuong
    {
        public void Check()
        {
            Console.WriteLine("kiem tra so duong hay so am");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập số
            Console.WriteLine("nhap so bat ki ");
            int a = int.Parse(Console.ReadLine());
            //điều kiện để số đó dương hay âm
            if (a >= 0)
                Console.WriteLine(a + " la so duong");
            else
                Console.WriteLine(a + " la so am");
            Console.ReadKey();

        }
    }
}
