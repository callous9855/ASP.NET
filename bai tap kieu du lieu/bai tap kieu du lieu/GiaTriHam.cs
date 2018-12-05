using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class GiaTriHam
    {
        public void Ham()
        {
            int x, y;
            Console.WriteLine("cho ham so: ");
            Console.WriteLine(" y = (x^3 + 3x)*x");
            for(x = -10; x<=10; x++)
            {
                y = (x * x * x + 3 * x) * x;
                Console.WriteLine("voi x = " + x + "   gia tri ham y la: " + y);
            }
            Console.ReadKey();
        }
    }
}
