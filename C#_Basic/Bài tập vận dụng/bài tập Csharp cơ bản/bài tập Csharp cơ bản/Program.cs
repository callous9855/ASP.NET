using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class Helloworld
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 5;
            b = 10;
            Console.WriteLine("Hello World!");
            Console.WriteLine("tong cua 15 và 20 la:");
            Console.WriteLine(15 + 20);
            Console.WriteLine("tong: {0}", a + b);
            Console.WriteLine("hieu: {0}", a - b);
            Console.WriteLine("nhan: {0}", a * b);
            Console.WriteLine("chia: {0}", b / a);
            
            Console.ReadKey();
            
        }
    }
}
