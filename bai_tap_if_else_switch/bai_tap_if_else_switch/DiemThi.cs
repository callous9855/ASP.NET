using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class DiemThi
    {
        public void tuyensinh()
        {
            Console.WriteLine("xet tuyen ba mon toan ly hoa");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("tieu chi xet tuyen");
            Console.WriteLine("toan ly hoa tren 5");
            Console.WriteLine("(toan * 2 + hoa + ly) > 27");
            //nhap diem toan ly hoa
            Console.WriteLine("nhap diem toan");
            float toan = Convert.ToSingle(Console.ReadLine());
            while(toan < 0 || toan > 10)
            {
                Console.WriteLine("nhap lai diem toan");
                toan = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("nhap diem ly");
            float ly = Convert.ToSingle(Console.ReadLine());
            while(ly < 0 || ly > 10)
            {
                Console.WriteLine("nhap lai diem ly");
                ly = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine("nhap diem hoa");
            float hoa = Convert.ToSingle(Console.ReadLine());
            while(hoa < 0 || hoa > 10)
            {
                Console.WriteLine("nhap lai diem hoa");
                hoa = Convert.ToSingle(Console.ReadLine());
            }
            //dieu kien de xet tuyen
            float DiemSan = toan * 2 + ly + hoa;
            if (toan > 5 && ly > 5 && hoa > 5 && DiemSan >= 27)
                Console.WriteLine("ban da trung tuyen");
            else
                Console.WriteLine("chuc ban may man lan sau");
            Console.ReadKey();
        }
    }
}
