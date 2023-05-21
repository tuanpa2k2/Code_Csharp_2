using System;
using System.Text;

namespace AAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            int n;
        A:
            Console.Clear();
            Console.WriteLine("...MENU...");
            Console.WriteLine("1: THÊM SINH VIÊN");
            Console.WriteLine("1: XUẤT DANH SÁCH SINH VIÊN");
            Console.WriteLine("1: LƯU FILE SINH VIÊN");
            Console.WriteLine("1: MỞ FILE SINH VIÊN");
            Console.WriteLine("1: XÓA SINH VIÊN");
            Console.WriteLine("1: LỌC SINH VIÊN");
            Console.WriteLine("1: SẮP XẾP SINH VIÊN");
            Console.WriteLine("0: THOÁT ...");
            Console.Write("Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {

                default:
                    break;
            }
        }
    }
}
