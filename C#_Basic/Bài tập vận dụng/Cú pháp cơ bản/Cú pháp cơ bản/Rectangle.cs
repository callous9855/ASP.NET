using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cú_pháp_cơ_bản
{
    class Rectangle
    {
        //Đây là 2 biến thành viên của lớp Rectangle chỉ có giá trị trong lớp
        double length;
        double width;

        //Lớp Rectangle chứa 3 hàm thành viên là: AcceptDetails, GetArea và Display.
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        //phuong thuc
        public double GetArea()
        {
            return length * width;
        }
        //phương thức
        public void Display()
        {
            Console.WriteLine("Chiều dài: {0}", length);
            Console.WriteLine("Chiều rộng: " + width);
            Console.WriteLine("Diện tích: {0}", GetArea());
        }
    }
}
