using System;
using System.Text;

namespace Asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceDanhBa cn = new ServiceDanhBa();
            int n;
        A:
            Console.Clear();
            Console.WriteLine("MENU CHỨC NĂNG DANH BẠ");
            Console.WriteLine("1: Thêm - Sửa - Xóa - Sắp xếp - Xuất danh sách.");
            Console.WriteLine("2: Lọc danh bạ");
            Console.WriteLine("3: Tìm kiếm");
            Console.WriteLine("4: Lưu trữ danh bạ");
            Console.WriteLine("0: THOÁT ...");
            Console.Write("Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1: //Lớn
                    Console.Clear();
                    int a;
                B:
                    Console.Clear();
                    Console.WriteLine("1: Thêm danh bạ");
                    Console.WriteLine("2: Sửa thông tin");
                    Console.WriteLine("3: Xóa thông tin");
                    Console.WriteLine("4: Sắp xếp danh bạ");
                    Console.WriteLine("5: Xuất danh sách");
                    Console.WriteLine("0: THOÁT ... ");
                    Console.Write("Mời bạn chọn chức năng: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    switch (a)
                    {
                        case 1: //thêm
                            Console.Clear();
                            cn.addDanhBa();
                            Console.ReadKey();
                            goto B;
                        case 2:  //sửa
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.updateDanhBa();
                            Console.ReadKey();
                            goto B;
                        case 3: //xóa
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.removeDanhBa();
                            Console.ReadKey();
                            goto B;
                        case 4: //sắp xếp
                            Console.Clear();
                            int x;
                        U:
                            Console.Clear();
                            Console.WriteLine("1: Xắp xếp theo tên A-Z");
                            Console.WriteLine("2: Xắp xếp theo tên Z-A");
                            Console.WriteLine("3: Thoát ");
                            Console.Write("Mời bạn chọn chức năng: ");
                            x = Convert.ToInt32(Console.ReadLine());
                            switch (x)
                            {
                                case 1: //Sắp xếp A-Z
                                    cn.sortXuoi();
                                    Console.ReadKey();
                                    goto U;
                                case 2: //Sắp xếp Z-A
                                    cn.sortNguoc();
                                    Console.ReadKey();
                                    goto U;
                                case 3: //Thoát sắp xếp
                                    Console.WriteLine("==> Thank You");
                                    break;
                                default: //Nhập lại sắp xếp
                                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                                    goto U;
                            }
                            Console.ReadKey();
                            goto B;
                        case 5: //Xuất danh sách
                            Console.Clear();
                            cn.getListDanhBa();
                            Console.ReadKey();
                            goto B;
                        case 0: //Thoát case_1.
                            Console.WriteLine("==> Thank You");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto B;
                    }
                    Console.ReadKey();
                    goto A;
                case 2: //Lớn
                    Console.Clear();
                    int k;
                Q:
                    Console.Clear();
                    Console.WriteLine("1: Lọc theo giới tính");
                    Console.WriteLine("2: Lọc theo bảng chữ cái");
                    Console.WriteLine("3: Lọc theo tên");
                    Console.WriteLine("4: Lọc theo sđt");
                    Console.WriteLine("5: Lọc theo nhà mạng");
                    Console.WriteLine("0: THOÁT ...");
                    Console.Write("Mời bạn chọn chức năng: ");
                    k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1: //lọc giới tính
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.LocGioiTinh();
                            Console.ReadKey();
                            goto Q;
                        case 2: //lọc bảng chữ cái
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.LocBangChuCai();
                            Console.ReadKey();
                            goto Q;
                        case 3: //lọc tên
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.LocTen();
                            Console.ReadKey();
                            goto Q;
                        case 4: //lọc sđt
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.LocSdt();
                            Console.ReadKey();
                            goto Q;
                        case 5: //lọc sđt
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.LocNhaMang1();
                            Console.ReadKey();
                            goto Q;
                        case 0: //Thoát case_2.
                            Console.WriteLine("==> Thank You");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto Q;
                    }
                    Console.ReadKey();
                    goto A;
                case 3: //Lớn
                    Console.Clear();
                    int m;
                C:
                    Console.Clear();
                    Console.WriteLine("1: Tìm kiếm theo tên gần đúng.");
                    Console.WriteLine("2: Tìm kiếm theo sđt gần đúng.");
                    Console.WriteLine("3: Thoát !");
                    Console.Write("Mời bạn chọn chức năng: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    switch (m)
                    {
                        case 1: //Tìm tên
                            Console.Clear();
                            cn.getListDanhBa();
                            cn.findTengandung();
                            Console.ReadKey();
                            goto C;
                        case 2: //Tìm sđt
                            Console.Clear();
                            cn.findSDTgandung();
                            Console.ReadKey();
                            goto C;
                        case 3: //Thoát case_3
                            Console.WriteLine("==> Thank You");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto C;
                    }

                    Console.ReadKey();
                    goto A;
                case 4:
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
                            cn.DocFile();
                            Console.ReadKey();
                            goto I;
                        case 2:
                            cn.GhiFile();
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
                case 0: //Lớn
                    cn.KiemTra();
                    break;
                default: //Lớn
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    goto A;
            }
        }
    }
}

