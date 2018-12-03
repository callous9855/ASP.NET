using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhap 3 chu cai va hien thi theo chieu nguoc lai
            Console.WriteLine("nhap 3 chu cai va hien thi theo chieu nguoc lai");
            Console.WriteLine("-----------------------------------------------");
            ThreeUnits units = new ThreeUnits();
            units.ChangePlace();
            //Vẽ tam giác số
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" ve tam gaic");
            VeTamGiac ve = new VeTamGiac();
            ve.tamgiac();
            //check ten tai khoan va mat khau
            //ten tai khoan va mat khau mac dinh "Admin" va "1234"
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            CheckUserPass check = new CheckUserPass();
            check.Check();
            //thực hiện phép toán với 2 số đã nhập lên màn hình
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            NhapPhepToan phepToan = new NhapPhepToan();
            phepToan.pheptoan();
        }
        
    }
}
