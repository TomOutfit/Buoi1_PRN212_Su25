using System;

namespace Phantichso
{
    public class Program
    {
        // Hàm phân tích số có 3 chữ số thành trăm, chục, đơn vị
        public static void PhanTichSo(int so, out int tram, out int chuc, out int donVi)
        {
            tram = so / 100;
            chuc = (so / 10) % 10;
            donVi = so % 10;
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên có 3 chữ số: ");
            int so = int.Parse(Console.ReadLine());

            if (so < 100 || so > 999)
            {
                Console.WriteLine("Vui lòng nhập số có đúng 3 chữ số (từ 100 đến 999).");
                return;
            }

            PhanTichSo(so, out int tram, out int chuc, out int donVi);

            Console.WriteLine($"\nSố {so} có:");
            Console.WriteLine($"Hàng trăm: {tram}");
            Console.WriteLine($"Hàng chục: {chuc}");
            Console.WriteLine($"Hàng đơn vị: {donVi}");
        }
    }
}
