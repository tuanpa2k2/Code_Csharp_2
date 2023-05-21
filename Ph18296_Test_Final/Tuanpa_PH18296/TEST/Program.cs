using System;
using System.Text;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLSV cn = new QLSV();

            int n;
        A:
            Console.Clear();
            Console.WriteLine("...MENU...");
            Console.WriteLine("1: Thêm sinh viên");
            Console.WriteLine("2: Xuất danh sách sinh viên");
            Console.WriteLine("3: Lưu file sinh viên");
            Console.WriteLine("4: Mở file sinh viên");
            Console.WriteLine("5: Xóa sinh viên");
            Console.WriteLine("6: Lọc sinh viên");
            Console.WriteLine("7: Sắp xếp sinh viên");
            Console.WriteLine("0: THOÁT ...");
            Console.Write("==> Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.AddSinhVien();
                    Console.ReadKey();
                    goto A;
                case 2:
                    Console.Clear();
                    cn.GetListSinhVien();
                    Console.ReadKey();
                    goto A;
                case 3:
                    cn.SaveFile();
                    Console.ReadKey();
                    goto A;
                case 4:
                    cn.OpenFile();
                    Console.ReadKey();
                    goto A;
                case 5:
                    cn.RemoveSinhVien();
                    Console.ReadKey();
                    goto A;
                case 6:
                    cn.LocSinhVien();
                    Console.ReadKey();
                    goto A;
                case 7:
                    cn.SortSinhVien();
                    Console.ReadKey();
                    goto A;
                case 0:
                    Console.WriteLine("==> THANK YOU AND SEE YOU !");
                    break;
                default:
                    Console.WriteLine("==> Bạn chọn sai chức năng, Vui lòng nhập lại !");
                    Console.ReadKey();
                    goto A;
            }

        }
    }
}
