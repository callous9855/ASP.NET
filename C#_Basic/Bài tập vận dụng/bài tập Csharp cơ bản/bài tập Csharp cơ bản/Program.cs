using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_Csharp_cơ_bản
{
    class Helloworld
    {
        //args lấy tham số từ bên ngoài vào chương trình
        //static cho phép hàm main() được gọi khi không cần khởi tạo đối tượng
        //void cho biết hàm main() không trả về giá trị
        static public void Main(string[] args)
        {
            //khai báo a,b
            int a, b;
            //gán a,b
            a = 5;
            b = 10;
            //writeline in gía trị ra màn hình xong sẽ tự động xuống dòng
            Console.WriteLine("Hello World!");
            Console.WriteLine("tong cua 15 và 20 la:");
            Console.WriteLine(15 + 20);
            //{0} 0 được điền tương ứng vào vị trí số 0, ở đây là biến a + b vì không còn giá trị khác nào biến đó
            Console.WriteLine("tong: {0}", a + b);
            Console.WriteLine("hieu: {0}", a - b);
            Console.WriteLine("nhan: {0}", a * b);
            Console.WriteLine("chia: {0}", b / a);
            //readkey dừng màn hình xem kết quả 
            //Chương trình C# để tráo đổi giá trị
            Console.WriteLine("\n\n");
            Console.WriteLine("chuong trinh hoan doi");
            Console.WriteLine("---------------------");
            Exchange r = new Exchange();
            r.exchange();
            //Chương trình C# để một số từ Input Stream chuẩn và in bảng nhân của số đó
            Console.WriteLine("\n\n");
            Console.WriteLine("bang nhan");
            Console.WriteLine("---------------------");
            Multipication multi = new Multipication();
            multi.multi();
            //Tìm giá trị trung bình của 4 số trong C#
            Console.WriteLine("\n\n");
            Console.WriteLine("Trung binh cong 4 so");
            Console.WriteLine("---------------------");
            Avg avg = new Avg();
            avg.avg();
            //Chuyển đổi độ C thành độ K và độ F
            Console.WriteLine("\n\n");
            Console.WriteLine("Doi do C sang do F");
            Console.WriteLine("---------------------");
            ExchangeTemearature temearature = new ExchangeTemearature();
            temearature.Tem();
        }
    }
}
