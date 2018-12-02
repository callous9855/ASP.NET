using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class Multipication
    {
        int c;
        public void multi()
        {
            Console.Write("nhap so bat ky ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("bang nhan cua " + c);
            for (int d = 1; d <= 10; d = d + 1)
            {
                Console.WriteLine(c + " nhan " + d + " =" + c * d);
            }
            Console.ReadKey();
        }
    }
}
