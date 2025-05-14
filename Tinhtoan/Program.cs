using System;

namespace Tinhtoan
{
    public class Program
    {
        // Hàm thực hiện 4 phép toán và trả về kết quả thông qua từ khóa out
        public static void TinhToan(int a, int b, out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong = b != 0 ? (double)a / b : double.NaN; // Tránh chia cho 0
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            TinhToan(a, b, out int tong, out int hieu, out int tich, out double thuong);

            Console.WriteLine($"\nKết quả:");
            Console.WriteLine($"Tổng: {tong}");
            Console.WriteLine($"Hiệu: {hieu}");
            Console.WriteLine($"Tích: {tich}");

            if (double.IsNaN(thuong))
                Console.WriteLine("Thương: Không xác định (chia cho 0)");
            else
                Console.WriteLine($"Thương: {thuong}");
        }
    }
}
