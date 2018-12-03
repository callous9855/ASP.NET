using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class NhapPhepToan
    {
        public void pheptoan()
        {
            Console.Write(" nhap so a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\n nhap so b ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("\n nhap phep toan ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.Write(a + " + " + b + " = " + (a + b));
            }
            else if (c == "-")
            {
                Console.Write(a + " - " + b + " = " + (a - b));
            }
            else if (c == "*")
            {
                Console.Write(a + " * " + b + " = " + (a * b));
            }
            else if (c == "/")
            {
                Console.Write(a + " / " + b + " = " + (a / b));
            }
            else
                Console.Write("phep toan khong hop le");

        }
    }
}
