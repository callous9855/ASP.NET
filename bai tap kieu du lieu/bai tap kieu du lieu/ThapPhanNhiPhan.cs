using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class ThapPhanNhiPhan
    {
        public void ChuyeDoi()
        {
            int a, du;
            Console.WriteLine("nhap so bat ki: ");
            a = int.Parse(Console.ReadLine());
            string kq = "";
            do
            {
                du = a % 2;
                kq = Convert.ToString(du) + kq;
                a = a / 2;
            } while (a > 1);
            Console.WriteLine(kq);
            Console.ReadKey();
        }
    }
}
