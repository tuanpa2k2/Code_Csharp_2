
using System;
using System.Text;

namespace BAI_1._6_DELEGATE_EVENT3
{
    class Program
    {
        class UserInput //Class đới tượng
        {
            //EventHandler: Là lớp sự kiện có sẵn, k cần tạo
            public event EventHandler suKienNhapSo;
            public void getInputValue()
            {
                Console.Write("Mời bạn nhập số nguyên 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập số nguyên 2: ");
                int b = Convert.ToInt32(Console.ReadLine());

                //Tương tự hành động tự phát sự kiện .
                suKienNhapSo.Invoke(this, new UserInput1(a, b)); // new UserInput1(a, b): Hứng 2 giá trị a, b của UserInput1
            }
        }
        class UserInput1: EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }
            public UserInput1(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class TinhTong
        {
            public void thiHanh(UserInput userInput)
            {
                userInput.suKienNhapSo += tinhTong;
            }
            private void tinhTong(object s, EventArgs e)
            {
                UserInput1 userInput1 = (UserInput1) e; //(UserInput1) e: Gán đối tượng
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", 
                    userInput1.a, userInput1.b, userInput1.a + userInput1.b);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            //Phát đi sự kiện
            UserInput userInput = new UserInput();
            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);
            //Thực thi
            userInput.getInputValue();
        }
    }
}
