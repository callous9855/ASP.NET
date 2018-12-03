using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class VeTamGiac
    {
        
        public void tamgiac()
        {
            Console.WriteLine("nhap so a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap chieu cao tam giac ");
            int cao = Convert.ToInt32(Console.ReadLine());
            int dai = cao;
            for (int hang = 0; hang < dai; hang++)
            {
                for (int cot = 0; cot < cao; cot++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                cao--;
            }
            Console.ReadKey();
        }
    }
}
