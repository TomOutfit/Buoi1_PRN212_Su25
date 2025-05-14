using FirstProject;

namespace FirstProject
{
    internal class Program
    {
        // Pass by Value : Truyền vào giá trị của 1 biến
        // ghi tên biến vào hàm

        // Pass by Reference : Truyền vào địa chỉ 1 biến
        // 'ref' or 'out'
        // Alibaba

        static void Main(string[] args)
        {
            // Dùng:
            //int so = 5;
            //TangLen(ref so); 
            //Console.WriteLine(so);

            //int kq; // @1212
            //TinhTong(2, 3,out kq);
            //Console.WriteLine(kq);

            int[] array = { 1, 2, 3, 4, 5 };

            foreach (int tay in array)
            {
                Console.WriteLine(tay);
            }


            //Console.WriteLine("Hello, World!");
            

            //string str = Console.ReadLine(); // Nhận value kiểu string
            //Console.WriteLine(str);
            // Integer.parseInt(); (Java)
            
            //try {
            //    num1 = int.Parse(Console.ReadLine());
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Please enter number! ");
            //}

            //string num1_raw = Console.ReadLine(); // abc

            //// TryParse( <string_can_parse> , out <bien_nhan_gia_tri_neu_parse_tc> )
            //int num1 = 0;
            //bool isNumber = int.TryParse(num1_raw, out num1);
            //if(isNumber == true)
            //{
            //    Console.WriteLine(num1);
            //}
        }

        // ref & out
        // ref : - Phải gán giá trị ban đầu cho biến trước khi truyền vào hàm
        //       - Có thể gán giá trị mới cho biến trong hàm (Không bắt buộc)
        //       - Thay đổi giá trị truyền vào    
        // out : - Không cần phải gán giá trị ban đầu cho biến trước khi truyền vào hàm
        //       - Phải gán giá trị trước khi thoát khỏi hàm
        //       - Trả về value từ 1 phương thức
        

        //REF
        static void TangLen(ref int a) // Tăng 1 món quà cho địa chỉ nhà tại quy Nhơn
        {
            a += 1;
        }

        //OUT
        static void TinhTong(int a, int b, out int c) {
          //@1212  
              c = a + b;
        }

        static int TinhTong(int a, int b)
        {
            return a + b;
        }



    }
}



