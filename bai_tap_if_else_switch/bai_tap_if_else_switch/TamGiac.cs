using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class TamGiac
    {
        public void tamgiac()
        {
            Console.WriteLine("phan loai chieu cao");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập 3 cạnh tam giác
            Console.WriteLine("nhap canh a");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a == null)
            {
                Console.WriteLine("nhap lai canh a (a>0)");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nhap canh b");
            int b = int.Parse(Console.ReadLine());
            while (b < 0)
            {
                Console.WriteLine("nhap lai canh b (b>0)");
                b = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nhap canh c");
            int c = int.Parse(Console.ReadLine());
            while (c < 0)
            {
                Console.WriteLine("nhap lai canh c (c>0)");
                c = int.Parse(Console.ReadLine());
            }
            //điều kiện tam giác cân, đều, nhọn
            if (a == b || b == c || c == a)
            {
                if (a == b && b == c)
                    Console.WriteLine("tam giac deu");
                else
                    Console.WriteLine("tam giac can");
            }
            else
                Console.WriteLine("tam giac nhon");

            Console.ReadKey();
        }
    }
}
