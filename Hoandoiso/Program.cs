using System;

namespace Hoandoiso
{
    public class Program
    {
        // Hàm hoán đổi giá trị hai biến sử dụng ref
        public static void HoanDoi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập số thứ nhất: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTrước khi hoán đổi: x = {x}, y = {y}");
            HoanDoi(ref x, ref y);
            Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}");
        }
    }
}
