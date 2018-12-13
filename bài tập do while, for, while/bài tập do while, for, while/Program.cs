using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_do_while__for__while
{
    class Program
    {
        static void Main(string[] args)
        {
            //tổng của dãy số
            Tong tongdayso = new Tong();
            tongdayso.dayso();
            //bảng cửu chương
            BangCuuChuong bang = new BangCuuChuong();
            bang.nhan();
            //số nguyên tố
            SoNguyenTo so = new SoNguyenTo();
            so.songuyento();
            //tìm số nguyên tố trong dãy
            so.tim();
            //bảng nhân của một số bất kỳ
            BangNhan bangNhan = new BangNhan();
            bangNhan.nhan();
            //tong so le
            tongdayso.tongle();
            //tong so chan
            tongdayso.tongchan();
            //ve tam giac
            VeTamGiac tamgiac = new VeTamGiac();
            tamgiac.tamgiacsao();
            tamgiac.tamgiacso();
            tamgiac.tamgiacso2();
            tamgiac.tamgiacso3();
            //tinh giai thua
            GiaiThua giaiThua = new GiaiThua();
            giaiThua.giaithua();
            //so hoan hao
            SoHoanHao hoanhao = new SoHoanHao();
            hoanhao.hoanhao();
            hoanhao.daysohoanhao();
            //day so Fibonacci
            DayFibonacci day = new DayFibonacci();
            day.Fibonacci();
            //in so theo chieu dao nguoc
            DaoNguoc dao = new DaoNguoc();
            dao.nguoc();
            //kiem tra so doi xung
            dao.SoDoiXung();
            //uoc chung lon nhat cua hai so
            UCLN uoc = new UCLN();
            uoc.UocChung();
            //boi chung nho nhat cua hai so
            BCNN Boi = new BCNN();
            Boi.BoiChung();
            //kiem tra strong number
            StrongNumber strong = new StrongNumber();
            strong.SN();
        }
    }
}
