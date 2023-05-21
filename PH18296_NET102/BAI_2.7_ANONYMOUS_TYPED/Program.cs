using System;
using System.Text;

namespace BAI_2._7_ANONYMOUS_TYPED
{
    class Program
    {
        public delegate void Method1(int temp);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //PHẦN_1: Khai báo Anonymous và Anonymous lồng nhau
            var svUDPM = new
            {
                Id = "PH123",
                Name = "TUAN",
                TrangThai = true
            };
            Console.WriteLine($"{svUDPM.Id} - {svUDPM.Name} - {svUDPM.TrangThai}");

            var svUDPM1 = new
            {
                Id = "PH123",
                Name = "TUAN",
                TrangThai = true,
                //Khai báo Anonymous lồng nhau
                Diachi = new
                {
                    SoNha = "So 1",
                    Duong = "Trinh Van Bo"
                }
            };
            Console.WriteLine($"{svUDPM1.Id} - {svUDPM1.Name} - {svUDPM1.TrangThai} - {svUDPM1.Diachi.SoNha} - {svUDPM1.Diachi.Duong}");

            //PHẦN_2: Phương thứ nặc danh
            Method1 method1 = delegate (int temp)
            {
                //có thể gọi các biến cục bộ ngoài phương thức như bình thường.
                Console.WriteLine("Đây là Method nặc danh. Giá trị = "+ temp);
            };
            method1(2021);

        }
    }
}
