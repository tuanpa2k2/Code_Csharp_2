using System;
using System.Text;

namespace BAI_0._0_BaiTapNangCao_DELEGATE
{
    class Program
    {
        static void Tong(int a, int b)
        {

        }
        class UserInput
        {
            public event EventHandler _inputNhapSo;
            public void getInputValue()
            {
                Console.Write("Mời bạn nhập số thứ nhất: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập số thứ hai: ");
                int b = Convert.ToInt32(Console.ReadLine());

                _inputNhapSo.Invoke(this, new UserInput1(a, b));
            }
        }
        class UserInput1 : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }
            public UserInput1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class PhepTinh
        {
            public void thiHanh(UserInput userInput)
            {
                userInput._inputNhapSo += tong;
                userInput._inputNhapSo += tru;
                userInput._inputNhapSo += nhan;
                userInput._inputNhapSo += chia;
            }
            private void chia(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Thương 2 số là: {0} / {1} = {2}", userInput1.a, userInput1.b, userInput1.a / userInput1.b);
            }
            private void nhan(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Tích 2 số là: {0} * {1} = {2}", userInput1.a, userInput1.b, userInput1.a * userInput1.b);
            }
            private void tru(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Hiệu 2 số là: {0} - {1} = {2}", userInput1.a, userInput1.b, userInput1.a - userInput1.b);
            }
            private void tong(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Tổng 2 số là: {0} + {1} = {2}", userInput1.a, userInput1.b, userInput1.a + userInput1.b);
            }
        }
        class PhepTong
        {
            public void thiHanh1(UserInput userInput)
            {
                userInput._inputNhapSo += tong;
            }
            private void tong(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Tổng 2 số là: {0} + {1} = {2}", userInput1.a, userInput1.b, userInput1.a + userInput1.b);
            }
        }
        class PhepTru
        {
            public void thiHanh2(UserInput userInput)
            {
                userInput._inputNhapSo += tru;
            }
            private void tru(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Hiệu 2 số là: {0} - {1} = {2}", userInput1.a, userInput1.b, userInput1.a - userInput1.b);
            }
        }
        class PhepNhan
        {
            public void thiHanh3(UserInput userInput)
            {
                userInput._inputNhapSo += nhan;
            }
            private void nhan(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Tích 2 số là: {0} * {1} = {2}", userInput1.a, userInput1.b, userInput1.a * userInput1.b);
            }
        }
        class PhepChia
        {
            public void thiHanh4(UserInput userInput)
            {
                userInput._inputNhapSo += chia;
            }
            private void chia(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1)e;
                Console.WriteLine(" Thương 2 số là: {0} / {1} = {2}", userInput1.a, userInput1.b, userInput1.a / userInput1.b);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Service service = new Service();
            UserInput cn = new UserInput();
            PhepTinh phepTinh = new PhepTinh();

            PhepTong phepTong = new PhepTong();
            PhepTru phepTru = new PhepTru();
            PhepNhan phepNhan = new PhepNhan();
            PhepChia phepChia = new PhepChia();

            int n;
            T:
            Console.WriteLine("MENU CHƯƠNG TRÌNH:");
            Console.WriteLine("1: Event DELEGATE ...");
            Console.WriteLine("2: Các phép toán cơ bản ...");
            Console.Write("Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("-------------------------------------------");
                    service.eventDelegate();
                    service.getListLapTrinhVien();
                    break;
                case 2:
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("1: Phép cộng");
                    Console.WriteLine("2: Phép trừ");
                    Console.WriteLine("3: Phép nhân");
                    Console.WriteLine("4: Phép chia");
                    Console.WriteLine("5: Phép tổng hợp(1,2,3,4)");
                    Console.Write("Mời bạn chọn chức năng: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            phepTong.thiHanh1(cn);
                            cn.getInputValue();
                            break;
                        case 2:
                            phepTru.thiHanh2(cn);
                            cn.getInputValue();
                            break;
                        case 3:
                            phepNhan.thiHanh3(cn);
                            cn.getInputValue();
                            break;
                        case 4:
                            phepChia.thiHanh4(cn);
                            cn.getInputValue();
                            break;
                        case 5:
                            phepTinh.thiHanh(cn);
                            cn.getInputValue();
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năng, Vui lòng nhập lại !");
                    goto T;
            }
        }
    }
}
