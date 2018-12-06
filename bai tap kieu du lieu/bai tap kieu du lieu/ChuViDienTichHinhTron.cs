using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class ChuViDienTichHinhTron
    {
        public void HinhTron()
        {
            double r, V, C;
            const double pi = 3.14;
            Console.Write("nhap ban kinh hinh tron (cm): ");
            r = Convert.ToDouble(Console.ReadLine());
            C = 2 * pi * r;
            V = pi * r * r;
            Console.WriteLine("chu vi hinh tron la: " + C);
            Console.Write("dien tich hinh tron la: " + V);
            Console.ReadKey();
        }
    }
}
