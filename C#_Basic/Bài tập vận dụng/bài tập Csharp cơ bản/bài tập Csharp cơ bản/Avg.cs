using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class Avg
    {
        int a, b, c, d;
        public void avg()
        {
            Console.Write("nhap 4 so ");
            a= int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            c= int.Parse(Console.ReadLine());
            d= int.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("gia tri trung binh cua 4 so da nhap la " + (a + b + c + d) / 4);
            Console.ReadKey();
        }
    }
}
