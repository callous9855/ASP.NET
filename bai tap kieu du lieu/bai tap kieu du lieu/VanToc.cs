using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class VanToc
    {
        public void V()
        {
            int v, s, t;
            Console.Write("nhap quang duong (m): ");
            s = int.Parse(Console.ReadLine());
            Console.Write("nhap thoi gian di (s): ");
            t = int.Parse(Console.ReadLine());
            v = s / t;
            Console.WriteLine("van toc di la: " + v + " (m/s) = " + (v * 3.6) + " (km/h) = " + (v * 2.24) + " (km/miles)");
            Console.ReadKey();
        }
    }
}
