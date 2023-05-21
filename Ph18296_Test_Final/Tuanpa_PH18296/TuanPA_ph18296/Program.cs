using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuanPA_ph18296
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            QLSV cn = new QLSV();

        T:
            int n;
            Console.Clear();
            Console.WriteLine(".. MENU ...");
            Console.WriteLine("1: Nhập danh sách");
            Console.WriteLine("2: Xuất danh sách");
            Console.WriteLine("3: Lưu File");
            Console.WriteLine("4: Đọc File");
            Console.WriteLine("5: Xóa danh sách");
            Console.WriteLine("6: Lọc danh sách");
            Console.WriteLine("7: Sắp xếp danh sách");
            Console.WriteLine("0: THOÁT");
            Console.Write("==> Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.AddSinhVien();
                    Console.ReadKey();
                    goto T;
                case 2:
                    cn.GetListSinhVien();
                    Console.ReadKey();
                    goto T;
                case 3:
                    cn.GhiFile();
                    Console.ReadKey();
                    goto T;
                case 4:
                    cn.DocFile();
                    Console.ReadKey();
                    goto T;
                case 5:
                    cn.RemoveSinhVien();
                    Console.ReadKey();
                    goto T;
                case 6:
                    cn.LocSinhVien();
                    Console.ReadKey();
                    goto T;
                case 7:
                    cn.SortSinhVien();
                    Console.ReadKey();
                    goto T;
                case 0:
                    Console.WriteLine("==> THANK YOU");
                    break;
                default:
                    Console.WriteLine("==> Bnạ chọn sai chức năg, Vui lòng nhập lại !");
                    goto T;
            }

        }
    }
}
