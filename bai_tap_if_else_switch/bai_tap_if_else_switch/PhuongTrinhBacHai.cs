using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class PhuongTrinhBacHai
    {
        public void giaiPT()
        {
            Console.WriteLine("phan loai chieu cao");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("phuong trinh bac hai co dang (a*x^2 + bx + c) = 0");
            //nhap a,b,c
            double x1, x2;
            Console.WriteLine("nhap a (a != 0) ");
            int a = int.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("nhap lai a (a != 0)");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("nhap b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("phuong trinh co dang: " + a + "*x^2" + b + "x" + c + " = 0");
            //xet delta va tim nghiem
            double Delta = (b * b) - (4 * a * c);
            Console.WriteLine("delta = " + Delta);
            if (Delta < 0)
                Console.WriteLine("phuong trinh vo nghiem");
            else if (Delta == 0)
            {
                Console.WriteLine("phuong trinh co nghiem kep");
                x1 = -b / (2 * a);
                Console.WriteLine("x1 = x2 =" + x1);
            }
            else
            {
                Console.WriteLine("phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
                Console.WriteLine("x1 =" + x1);
                Console.WriteLine("x2 =" + x2);
            }
            Console.ReadKey();
                
        }
    }
}
