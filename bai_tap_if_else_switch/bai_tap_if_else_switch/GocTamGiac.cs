using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class GocTamGiac
    {
        public void Goc()
        {
            Console.WriteLine("kiem tra goc tam giac");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập 3 số bất kỳ
            Console.WriteLine("nhap so thu nhat");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap so thu hai");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("nhap so thu ba");
            float c = Convert.ToSingle(Console.ReadLine());
            //điều kiện để 3 số đó là 3 góc tam giác
            if(a> 0 && b>0 && c > 0 && a + b + c == 180)
                Console.WriteLine("3 so vua nhap la 3 goc cua tam giac");
            else
                Console.WriteLine("3 so vua roi khong phai la 3 goc cua tam giac");
            Console.ReadKey();
        }
    }
}
