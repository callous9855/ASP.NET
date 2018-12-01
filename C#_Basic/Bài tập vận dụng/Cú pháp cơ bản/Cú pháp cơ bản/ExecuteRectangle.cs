using System; // khai báo 'sử dụng' thư viện "hệ thống", tất cả hàm Console.WriteLine hay Readline đều được lấy để sử dụng từ thư viện này
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trong 1 chương trình có thể dùng nhiều lệnh using

namespace Cú_pháp_cơ_bản //là khai báo 1 namespace chưa 1 tập hợp các lớp như ExcuteRectangle và Rectangle
{
    class ExecuteRectangle // trong lớp ExecuteRectangle chỉ có 1 phương thức main
    {
        //Đây là 1 phương thức: method hay cũng có thể gọi là hàm function
        static void Main(string[] args)  //khi chạy, C# chỉ thực thi mọi thứ trong hàm main, vì vậy, các hàm bên ngoài, khi không được gọi trong main sẽ không được chạy
        {
            Console.WriteLine("Chuong trinh minh hoa tinh huong doi tuong trong C#");
            Console.WriteLine("--------------------------------------------------\n");
            //tao doi tuong Rectangle có biến là r
            Rectangle r = new Rectangle(); 
            //goi cac phuong thuc cua doi tuong nay
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
