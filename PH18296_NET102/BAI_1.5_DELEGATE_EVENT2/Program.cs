using System;
using System.Text;

namespace BAI_1._5_DELEGATE_EVENT2
{
    class Program
    {
        public delegate void SuKienNhapSo(int x, int y);
        class UserInput //Class đới tượng
        {
            public event SuKienNhapSo suKienNhapSo;
            public void getInputValue()
            {
                Console.Write("Mời bạn nhập số nguyên 1: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập số nguyên 2: ");
                int b = Convert.ToInt32(Console.ReadLine());

                //Tương tự hành động tự phát sự kiện .
                suKienNhapSo.Invoke(a, b);
            }
        }
        class TinhTong
        {
            public void thiHanh(UserInput userInput)
            {
                userInput.suKienNhapSo += tinhTong;
            }

            private void tinhTong(int x, int y)
            {
                Console.WriteLine("Tổng 2 số: {0} + {1} = {2}", x, y, x + y);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            //Phá đi sự kiện
            UserInput userInput = new UserInput();
            //Nhận sự kiện
            TinhTong tinhTong = new TinhTong();
            tinhTong.thiHanh(userInput);
            //Thực thi
            userInput.getInputValue();
        }
    }
}
