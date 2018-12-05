using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class SoChanLe
    {
        public void ChanLe()
        {
            Console.WriteLine("nhap so bat ki: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("a la so chan");
            else
                Console.WriteLine("a la so le");
        }
    }
}
