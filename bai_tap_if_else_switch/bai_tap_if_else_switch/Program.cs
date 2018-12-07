using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_if_else_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhập hai số và kiểm tra xem hai số đó có bằng nhau không
            KiemTraHaiSo kiemTra = new KiemTraHaiSo();
            kiemTra.Check();
            //kiểm tra số dương, số âm
            CheckAmDuong so = new CheckAmDuong();
            so.Check();
            //Kiểm tra năm nhuận
            Nam nam = new Nam();
            nam.NamNhuan();
            //kiểm tra và thông báo xem có đủ độ tuổi bầu cử không.
            BauCu bauCu = new BauCu();
            bauCu.baucu();
            //phân loại chiều cao theo tiêu chuẩn (Huy)
            PhanLoaiChieuCao loaiChieuCao = new PhanLoaiChieuCao();
            loaiChieuCao.phanloai();
            //nhập tọa độ (x, y) của một điểm và thông báo góc phần tư
            ToaDo toaDo = new ToaDo();
            toaDo.gocphantu();
            //nhập điểm thi ba môn Toán, Lý, Hóa của một thí sinh, kiểm tra xem thí sinh đó có trúng tuyển không
            DiemThi diemThi = new DiemThi();
            diemThi.tuyensinh();
            //giải phương trình bậc hai
            PhuongTrinhBacHai bachai = new PhuongTrinhBacHai();
            bachai.giaiPT();
            //kiểm tra tam giac
            TamGiac a = new TamGiac();
            a.tamgiac();
            //kiểm tra 3 số bất kỳ có phải là 3 góc tam giác không
            GocTamGiac goc = new GocTamGiac();
            goc.Goc();
            //kiểm tra nguyên âm phụ âm
            NguyenAmPhuAm am = new NguyenAmPhuAm();
            am.KiemTra();
            //kiểm tra lợi nhuận, thua lỗ
            LoiNhuan loinhuan = new LoiNhuan();
            loinhuan.tinh();
            //nhập một số và hiển thị ngày trong tuần tương ứng
            HienThiNgay ngay = new HienThiNgay();
            ngay.ngay();
            //Nhập một số bất kỳ và hiển thị số bằng chữ tương ứng
            HienThiSo hien = new HienThiSo();
            hien.So();
        }
    }
}
