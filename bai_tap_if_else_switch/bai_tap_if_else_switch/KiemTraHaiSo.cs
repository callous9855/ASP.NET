using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class KiemTraHaiSo
    {
        public void Check()
        {
            Console.WriteLine("kiem tra hai so co bang nhau khong");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập 2 số
            Console.WriteLine("nhap 2 so bat ki");
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            //so sánh 2 số đã nhập
            if (a > b)
                Console.WriteLine(a + " lon hon " + b);
            else if (a < b)
                Console.WriteLine(a + " be hon " + b);
            else
                Console.WriteLine(a + " bang " + b);
            Console.ReadKey();
        }
    }
}
