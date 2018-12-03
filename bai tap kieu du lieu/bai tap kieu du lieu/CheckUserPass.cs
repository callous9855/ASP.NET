using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_kieu_du_lieu
{
    class CheckUserPass
    {
        public void Check()
        {
            Console.WriteLine("nhap ten dang nhap :");
            string UserName = Console.ReadLine();
            Console.WriteLine("nhap mat khau :");
            string PassWord = Console.ReadLine();
            //kiem tra ten dang nhap va mat khau neu khong dung phai dang nhap lai neu nhap sai qua 3 lan thi khong duoc nhap nua
            for (int count = 1; count <= 3; count++)
            {
               if (count < 3)
                {
                    if (UserName != "Admin" && PassWord != "1234")
                    {
                        Console.WriteLine("ten dang nhap hoac mat khau sai");
                        Console.WriteLine("nhap lai ten dang nhap :");
                        UserName = Console.ReadLine();
                        Console.WriteLine("nhap lai mat khau :");
                        PassWord = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("dang nhap thanh cong");
                        break;
                    }
                }
               else
                    Console.Write("ban da dang nhap qua so lan cho phep vui long khong dang nhap nua :)))");

            }
            Console.ReadKey();
        }
    }
}
