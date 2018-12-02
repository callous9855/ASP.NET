using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class ExchangeTemearature
    {
        int a, b;
        public void Tem()
        {
            Console.Write("nhap do C ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n");
            b = a + 273;
            Console.Write(a + " do C = " + b + " do F");
            Console.ReadKey();
        }
    }
}
