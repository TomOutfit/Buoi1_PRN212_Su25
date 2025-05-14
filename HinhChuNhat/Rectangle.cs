namespace HinhChuNhat
{
    public class Rectangle
    {
        // Thuộc tính
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        // Tính chu vi
        public double TinhChuVi()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        // Tính diện tích
        public double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        // Hiển thị thông tin
        public void HienThiThongTin()
        {
            Console.WriteLine($"Chiều dài: {ChieuDai}");
            Console.WriteLine($"Chiều rộng: {ChieuRong}");
            Console.WriteLine($"Chu vi: {TinhChuVi()}");
            Console.WriteLine($"Diện tích: {TinhDienTich()}");
        }
    }
}
