using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class LoiNhuan
    {
        public void tinh()
        {
            int loi_nhuan, Doanh_thu, chi_phi;
            Console.WriteLine("kiem tra loi nhuan thua lo");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("nhap doanh thu thang nay");
            Doanh_thu = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap chi phi thang nay");
            chi_phi = int.Parse(Console.ReadLine());
            loi_nhuan = Doanh_thu - chi_phi;
            if (loi_nhuan > 0)
                Console.WriteLine("loi nhuan thang nay la: "+ loi_nhuan);
            else
                Console.WriteLine("thang nay thua lo: " + loi_nhuan);
            Console.ReadKey();
        }
    }
}
