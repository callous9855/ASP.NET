using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class NguyenAmPhuAm
    {
        public void KiemTra()
        {
            Console.WriteLine("kiem tra nguyen am phu am");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập chữ cái
            Console.WriteLine("nhap chu cai bat ky");
            char chu = Convert.ToChar(Console.ReadLine().ToLower());
            if (chu == 'a' || chu == 'u' || chu == 'i' || chu == 'e' || chu == 'o')
                Console.WriteLine("day la nguyen am");
            else
                Console.WriteLine("khong phai la nguyen am");
            Console.ReadKey();
        }
    }
}
