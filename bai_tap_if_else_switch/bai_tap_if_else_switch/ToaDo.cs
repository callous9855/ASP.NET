using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class ToaDo
    {
        public void gocphantu()
        {
            Console.WriteLine("nhap toa do mot diem va thong bao goc phan tu");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            //nhập các điểm tọa độ
            Console.WriteLine("nhap tung do");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap hoanh do");
            int y = Convert.ToInt32(Console.ReadLine());
            //điều kiện để chia góc phần tư
            if (x > 0 && y > 0)
                Console.WriteLine("toa do ( " + x + " ; " + y + " ) nam o goc phan tu thu nhat");
            else if (x > 0 && y < 0)
                Console.WriteLine("toa do ( " + x + " ; " + y + " ) nam o goc phan tu thu hai");
            else if (x < 0 && y < 0)
                Console.WriteLine("toa do ( " + x + " ; " + y + " ) nam o goc phan tu thu ba");
            else
                Console.WriteLine("toa do ( " + x + " ; " + y + " ) nam o goc phan tu thu tu");
            Console.ReadKey();

        }
    }
}
