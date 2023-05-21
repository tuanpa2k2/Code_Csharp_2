using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Assignment
{
    class Program
    {
        static bool numbercheck;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceDanhBa dB = new ServiceDanhBa();
            dB.DocFile();
            int n;
            T:
            {
                Console.Clear();
                menu();
            }
            do
            {
                try
                {
                    Console.WriteLine("--------------------------------------------------------------");
                n = getvalues(getInputValue("-=-Mời bạn chọn chức năng: "));
                Console.WriteLine("--------------------------------------------------------------");
                switch (n)
                    {
                        case 1:
                            Console.Clear();
                            Q:
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine(" 1: Thêm người vào trong danh bạ");
                            Console.WriteLine(" 2: Sửa người vào trong danh bạ");
                            Console.WriteLine(" 3: Xóa người vào trong danh bạ");
                            Console.WriteLine(" 4: In Danh sách");
                            Console.WriteLine(" 5: Sắp xếp");
                            Console.WriteLine(" 6: Thoát.");
                            do
                            {
                                Console.WriteLine("--------------------------------------------------------------");
                                n = getvalues(getInputValue("-=- Mời bạn chọn chức năng: "));
                                Console.WriteLine("--------------------------------------------------------------");
                                switch (n)
                                {
                                    case 1:
                                        Console.Clear();
                                        dB.themNguoi();
                                        Console.WriteLine("Thêm thành công");
                                        Console.ReadKey();
                                        goto Q;
                                    case 2:
                                        Console.Clear();
                                        dB.suaNguoi();
                                        Console.ReadKey();
                                        goto Q;
                                    case 3:
                                        Console.Clear();
                                        dB.xoaNguoi();
                                        Console.ReadKey();
                                        goto Q;
                                    case 4:
                                        dB.xuatDanhSach();
                                        Console.ReadKey();
                                        goto Q;
                                    case 5:
                                        Console.Clear();
                                        Console.Write("Sắp xếp(1-xuôi, 2-ngược) :");
                                        n = getvalues(Console.ReadLine());
                                        switch (n)
                                        {
                                            case 1:
                                                dB.sapxepxuoi();
                                                Console.WriteLine("Sắp xếp thành công");
                                                break;
                                            case 2:
                                                dB.sapxepnguoc();
                                                Console.WriteLine("Sắp xếp thành công");
                                                break;
                                            default:
                                                Console.WriteLine("Không có chức năng này");
                                                break;
                                        }
                                        Console.ReadKey();
                                        goto Q;
                                    default:
                                        Console.WriteLine("Không có chức năng này, Vui lòng nhập lại !");
                                        break;
                                }
                            } while (!(n == 6));
                            Console.WriteLine("Kết thúc chức năng");
                            goto T;
                        case 2:
                            Console.Clear();
                            W:
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine(" 1: Lọc theo bảng chữ cái");
                            Console.WriteLine(" 2: Lọc theo tên");
                            Console.WriteLine(" 3: Lọc theo giới tính");
                            Console.WriteLine(" 4: Lọc theo nhà mạng");
                            Console.WriteLine(" 5: Thoát.");
                            do
                            {
                                Console.WriteLine("--------------------------------------------------------------");
                                n = getvalues(getInputValue("-=- Mời bạn chọn chức năng: "));
                                Console.WriteLine("--------------------------------------------------------------");
                                switch (n)
                                {
                                    case 1:
                                        Console.Clear();
                                        dB.loctheoabc();
                                        Console.ReadKey();
                                        goto W;
                                    case 2:
                                        Console.Clear();
                                        dB.loctheoten();
                                        Console.ReadKey();
                                        goto W;
                                    case 3:
                                        Console.Clear();
                                        dB.loctheogioitinh();
                                        Console.ReadKey();
                                        goto W;
                                case 4:
                                        Console.Clear();
                                        dB.locnhamang();
                                        Console.ReadKey();
                                        goto W;
                                default:
                                        Console.WriteLine("Không có chức năng này, Vui lòng nhập lại !");
                                        break;
                                }
                            } while (!(n == 5));
                            Console.WriteLine("Kết thúc chức năng");
                            goto T;
                        case 3:
                            Console.Clear();
                            E:
                            Console.Clear();
                            Console.WriteLine(" 1: Tìm kiếm theo tên gần đúng :");
                            Console.WriteLine(" 2: Tìm kiếm theo sđt gần đúng :");
                        do
                        {
                            n = getvalues(getInputValue("Chọn chức năng : "));
                            switch (n)
                            {
                                case 1:
                                    Console.Clear();
                                    dB.TimTengandung();
                                    Console.ReadKey();
                                    goto E;
                                case 2:
                                    Console.Clear();
                                    dB.TimSDTgandung();
                                    Console.ReadKey();
                                    goto E;
                                default:
                                    Console.WriteLine("Không có chức năng này");
                                    break;
                            }
                        } while (!(n == 3)) ;
                            Console.ReadKey();
                            Console.Clear();
                            goto T;
                        case 4:
                            Console.Clear();
                            dB.GhiFile();
                            Console.WriteLine("Ghi File thành công");
                            Console.ReadKey();
                            Console.Clear();
                            goto T;
                        case 5:
                            Console.WriteLine("Chương trình kết thúc");
                            dB.KiemTra();
                            break;
                        default:
                            Console.WriteLine("Không có chức năng này, Vui lòng nhập lại !");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Đã có lỗi xảy ra");
                    Console.ReadKey();
                    menu();
                }
            } while (true);
            string getInputValue(string mess)
            {
                string vals;
               
                do
                {
                    Console.Write("" + mess);
                    vals = Console.ReadLine();
                    numbercheck = false;
                    try
                    {
                        Check(vals);
                    }
                    catch (Exception )
                    {
                    }

                } while (numbercheck);
                return vals;
            }
        }
        static void Check(string ten)
        {
            if (string.IsNullOrEmpty(ten))
            {
                numbercheck = true;
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("(vui lòng nhập dữ liệu.)");
            }
        }
        static int getvalues(string name)
        {
            int r = 0;
            try
            {
                r = Convert.ToInt32(name);
            }
            catch (Exception )
            {
            }
            return r;
        }
        static void menu()
        {
            Console.WriteLine("----- MENU các chức năng danh bạ của bạn -----");
            Console.WriteLine("1: QUẢN LÝ DANH BẠ");
            Console.WriteLine("2: LỌC DANH BẠ");
            Console.WriteLine("3: TÌM KIẾM");
            Console.WriteLine("4: LƯU TRỮ DANH BẠ");
            Console.WriteLine("5: THOÁT");
        }
    }
}