using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class ThreeUnits
    {
        char a, b, c;
        public void ChangePlace()
        {
            Console.WriteLine("nhap ki tu dau tien: ");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("nhap ki tu thu hai: ");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("nhap ki tu thu ba: ");
            c = Convert.ToChar(Console.ReadLine());
            //{0},{1},{2} tuong ung voi cac vi tri 0,1,2 cua c,b,a
            Console.Write("hien thi ba ki tu theo chieu nguoc lai {2} {1} {0}", a, b, c);
            Console.ReadKey();
        }
    }
}
