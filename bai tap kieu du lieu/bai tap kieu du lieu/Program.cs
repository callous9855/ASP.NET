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
            //chu vi dien tich hinh tron
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            ChuViDienTichHinhTron chuViDienTich = new ChuViDienTichHinhTron();
            chuViDienTich.HinhTron();
            //Tìm giá trị cụ thể của hàm tương ứng với mỗi giá trị biến trong dãy đã cho
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            GiaTriHam giaTriHam = new GiaTriHam();
            giaTriHam.Ham();
            //Tìm vận tốc (m/s, km/h, mile/h) với quãng đường và thời gian nhập từ bàn phím
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            VanToc vanToc = new VanToc();
            vanToc.V();
            //kiểm tra số chẵn số lẻ
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            SoChanLe chanLe = new SoChanLe();
            chanLe.ChanLe();
            //chuyen he thap phan sang he nhi phan
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            ThapPhanNhiPhan phan = new ThapPhanNhiPhan();
            phan.ChuyeDoi();

        }

    }
}
