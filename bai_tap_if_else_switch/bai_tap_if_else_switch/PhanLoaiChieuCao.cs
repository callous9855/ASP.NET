using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class PhanLoaiChieuCao
    {
        public void phanloai()
        {
            Console.WriteLine("phan loai chieu cao");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập chiều cao
            Console.WriteLine("nhap chieu cao cua ban vao day (cm)");
            int chieucao = Convert.ToInt16(Console.ReadLine());
            //phân loại
            while (chieucao > 250 || chieucao < 0)
            {
                Console.WriteLine("chieu cao khong hop le, ban vui long nhap lai chieu cao");
                chieucao = Convert.ToInt16(Console.ReadLine());
            }
            if (chieucao < 150)
                Console.WriteLine("chieu cao thuoc dang thap, uong sua cho mau lon");
            else if (chieucao > 175)
                Console.WriteLine("cao");
            else
                Console.WriteLine("chieu cao trung binh");
            Console.ReadKey();
        }
    }
}
