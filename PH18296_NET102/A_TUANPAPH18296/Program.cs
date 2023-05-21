using System;
using System.Text;

namespace A_TUANPAPH18296
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLSV cn = new QLSV();
            
            int n;
        N:
            Console.Clear();
            Console.WriteLine("*** MENU ***");
            Console.WriteLine("1: Nhập danh sách ");
            Console.WriteLine("2: Xuất danh sách ");
            Console.WriteLine("3: Lưu file ");
            Console.WriteLine("4: Đọc file ");
            Console.WriteLine("5: Xóa danh sách ");
            Console.WriteLine("6: Lọc danh sách ");
            Console.WriteLine("7: Sắp xếp danh sách");
            Console.WriteLine("0: THOÁT");
            Console.Write("MỜI BẠN CHỌN CHỨC NĂNG: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.AddSinhVien();
                    Console.ReadKey();
                    goto N;
                case 2:
                    Console.Clear();
                    cn.GetListSinhVien();
                    Console.ReadKey();
                    goto N;
                case 3:
                    cn.GhiFile();
                    Console.ReadKey();
                    goto N;
                case 4:
                    cn.DocFile();
                    Console.ReadKey();
                    goto N;
                case 5:
                    Console.Clear();
                    cn.RemoveSinhVien();
                    Console.ReadKey();
                    goto N;
                case 6:
                    cn.LocSinhVien();
                    Console.ReadKey();
                    goto N;
                case 7:
                    Console.Clear();
                    cn.GetListSinhVien();
                    cn.SortSinhVien();
                    Console.ReadKey();
                    goto N;
                case 0:
                    cn.checkSo();
                    Console.WriteLine("==> Thank You ...");
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    goto N;
            }

        }
    }
}
