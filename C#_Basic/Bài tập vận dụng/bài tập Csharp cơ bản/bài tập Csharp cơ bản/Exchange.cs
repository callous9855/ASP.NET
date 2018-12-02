using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class Exchange
    {
        int n1, n2, extra;
        public void exchange()
        {
            Console.WriteLine("nhap so a");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b");
            //readline() de nhap gia tri tu ban phim
            n2 = int.Parse(Console.ReadLine());
            extra = n1;
            n1 = n2;
            n2 = extra;
            Console.WriteLine("sau khi hoan doi");
            Console.WriteLine("so a la " + n1);
            Console.WriteLine("so b la " + n2);
            Console.ReadKey();
        }
    }
}
