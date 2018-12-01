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
        static void Main(string[] args)
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
            Console.ReadKey();
            
        }
    }
}
