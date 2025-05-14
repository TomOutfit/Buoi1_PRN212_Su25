using System;

namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle hcn = new Rectangle();

            Console.Write("Nhập chiều dài: ");
            hcn.ChieuDai = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            hcn.ChieuRong = double.Parse(Console.ReadLine());

            Console.WriteLine("\nThông tin hình chữ nhật:");
            hcn.HienThiThongTin();
        }
    }
}
