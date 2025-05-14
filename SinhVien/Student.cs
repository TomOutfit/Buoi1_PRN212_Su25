using System;

namespace SinhVien
{
    public class Student
    {
        // Thuộc tính
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public double DiemTB { get; set; }

        // Nhập thông tin từ bàn phím
        public void NhapThongTin()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSV = Console.ReadLine();

            Console.Write("Nhập tên sinh viên: ");
            TenSV = Console.ReadLine();

            Console.Write("Nhập điểm trung bình: ");
            DiemTB = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin sinh viên
        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSV}");
            Console.WriteLine($"Tên SV: {TenSV}");
            Console.WriteLine($"Điểm TB: {DiemTB}");
            Console.WriteLine($"Xếp loại: {XepLoai()}");
            Console.WriteLine("-----------------------------------");
        }

        // Trả về xếp loại dựa trên điểm
        public string XepLoai()
        {
            if (DiemTB >= 8.0)
                return "Giỏi";
            else if (DiemTB >= 6.5)
                return "Khá";
            else if (DiemTB >= 5.0)
                return "Trung Bình";
            else
                return "Yếu";
        }
    }
}
