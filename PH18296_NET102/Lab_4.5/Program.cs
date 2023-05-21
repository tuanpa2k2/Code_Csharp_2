using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string path = @"E:\C#_2\PH18296_NET102\Lab_4.5\data.bin";
            ServiceStudent cn = new ServiceStudent();
            List<SinhVien> sinhViens = new List<SinhVien>
            {
                new SinhVien(0, "PH1", "TUAN", 1, 3, true),
                new SinhVien(1, "PH2", "THAO", 2, 1, false),
                new SinhVien(2, "PH3", "THI", 3, 2, true)
        };


            int s;
        A:
            Console.Clear();
            Console.WriteLine("MENU CÁC CHỨC NĂNG");
            Console.WriteLine("1: Thêm - Sửa - Xóa - In danh sách");
            Console.WriteLine("2: Lọc danh sách");
            Console.WriteLine("3: Lưu trữ");
            Console.WriteLine("4: THOÁT ...");
            Console.Write("Mời bạn chọn chức năng: ");
            s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    Console.Clear();
                    int z;
                Z:
                    Console.Clear();
                    Console.WriteLine("1: Thêm sinh viên");
                    Console.WriteLine("2: Sửa thông tin sinh viên");
                    Console.WriteLine("3: Xóa thông tin sinh viên");
                    Console.WriteLine("4: In danh sách sinh viên");
                    Console.WriteLine("0: THOÁT ...");
                    Console.Write("Mời bạn chọn chức năng: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    switch (z)
                    {
                        case 1:
                            Console.Clear();
                            cn.AddStudent();
                            Console.ReadKey();
                            goto Z;
                        case 2:
                            Console.Clear();
                            cn.GetlistStudent();
                            cn.UpdateStudent();
                            Console.ReadKey();
                            goto Z;
                        case 3:
                            Console.Clear();
                            cn.GetlistStudent();
                            cn.RemoveStudent();
                            Console.ReadKey();
                            goto Z;
                        case 4:
                            Console.Clear();
                            cn.GetlistStudent();
                            Console.ReadKey();
                            goto Z;
                        case 0:
                            Console.WriteLine("THANK YOU ...!");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto Z;
                    }

                    Console.ReadKey();
                    goto A;
                case 2:
                    Console.Clear();
                    int t;
                T:
                    Console.Clear();
                    Console.WriteLine("1: Lọc danh sách theo ngành học");
                    Console.WriteLine("2: Lọc danh sách theo trạng thái học");
                    Console.WriteLine("0: Thoát ...");
                    Console.Write("Mời bạn chọn chức năng: ");
                    t = Convert.ToInt32(Console.ReadLine());
                    switch (t)
                    {
                        case 1:
                            Console.Clear();
                            cn.GetlistStudent();
                            cn.LocNganh();
                            Console.ReadKey();
                            goto T;
                        case 2:
                            Console.Clear();
                            cn.GetlistStudent();
                            cn.LocTrangThai();
                            Console.ReadKey();
                            goto T;
                        case 0:
                            Console.WriteLine("==> THANK YOU ...");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto T;
                    }

                    Console.ReadKey();
                    goto A;
                case 3:
                    Console.Clear();
                    int i;
                I:
                    Console.Clear();
                    Console.WriteLine("1: Mở file data");
                    Console.WriteLine("2: Lưu file data");
                    Console.WriteLine("0: Thoát ...");
                    Console.Write("Mời bạn chọn chức năng: ");
                    i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.Clear();
                            cn.MoFile();
                            foreach (var x in cn.GetListStudents())
                            {
                                x.InRaManHinh();
                            }
                            Console.ReadKey();
                            goto I;
                        case 2:
                            cn.GhiFile(path);
                            Console.ReadKey();
                            goto I;
                        case 0:
                            Console.WriteLine("==> THANK YOU ...");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto I;
                    }
                    Console.ReadKey();
                    goto A;
                case 4:
                    Console.WriteLine("Thank You ...!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    goto A;
            }

        }
    }
}
