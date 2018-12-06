using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class BauCu
    {
        public void baucu()
        {
            Console.WriteLine("kiem tra do tuoi bau cu");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            //nhập tuổi
            Console.WriteLine("nhap vao tuoi cua ban: ");
            int tuoi = Convert.ToInt16(Console.ReadLine());
            //điều kiện để tuổi có nghĩa
            while (tuoi < 0 || tuoi > 130)
            {
                Console.WriteLine("vui long nhap lai tuoi: ");
                tuoi = Convert.ToInt16(Console.ReadLine());
            }
            //điều kiện để bầu cử
            if(tuoi >= 18)
                Console.WriteLine("ban da du tuoi de tham gia bau cu");
            else
                Console.WriteLine("ban hay cho them "+(18-tuoi)+" nam nua de bau cu :))");
            Console.ReadKey();
        }
    }
}
