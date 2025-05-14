using System;
using System.Collections.Generic;

namespace SinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> danhSachSV = new List<Student>();

            Console.WriteLine("=== Nhập thông tin cho 3 sinh viên ===\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"--- Sinh viên thứ {i + 1} ---");
                Student sv = new Student();
                sv.NhapThongTin();
                danhSachSV.Add(sv);
                Console.WriteLine();
            }

            Console.WriteLine("\n=== Thông tin và xếp loại sinh viên ===\n");

            foreach (var sv in danhSachSV)
            {
                sv.HienThiThongTin();
            }
        }
    }
}
