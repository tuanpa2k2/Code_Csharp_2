using System;
using System.Text;

namespace BAI_1._2_DELEGATE
{

    class Program
    {
        #region Bài về Delegate
        /*
        * Định nghĩa:
            * ❑Delegate là một biến chứa tham chiếu đến phương thức cần thực thi.
              ❑Một delegate có thể trỏ tới một hoặc nhiều phương thức
              ❑Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi
              ❑
        * + Có thể khai báo trong namespace hoặc khai báo trong class
        * + Khi khai báo giống như khai báo một phương thức
        * + Công thức:
        *      <phạm vi truy cập> delegate <kiểu phương thức> <tên>(<Tham số>); 
        */
        public delegate void ShowMessage(string mess); //khai báo

        static void Info1(string s)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Info1 = " + s);
            Console.ResetColor();
        }
        static void Info2(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info2 = " + s);
            Console.ResetColor();
        }
        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //*P1: Khởi tạo DELEGATE null
            Console.WriteLine("======P1: Khởi tạo DELEGATE null=======");

            ShowMessage showMessage = null;
            showMessage = Info1; //Gán phương thức mà delegate sẽ trỏ đến phương thức đó.
            //showMessage("Chào các bạn học DELEGATE");
            showMessage?.Invoke("Chào các bạn học DELEGATE"); //ktra xem delegate có null hay không, và nếu k null thì sẽ thực thi (dấu ? : chống bị lỗi)

            //*P2: Khởi tạo DELEGATE
            Console.WriteLine("======P2: Khởi tạo DELEGATE=======");
            ShowMessage showMessage2 = new ShowMessage(Info2);
            showMessage2("Chào các bạn FPL học DELEGATE_2");

            //*P3: C# Multicast Delegates
            Console.WriteLine("======P3: C# Multicast Delegates=======");
            ShowMessage showMessage3 = new ShowMessage(Info1);
            ShowMessage showMessage4 = new ShowMessage(Info2);
            //c1: 
            ShowMessage multicastMessage = showMessage3 + showMessage4;
            //c2: 
            multicastMessage += showMessage3;
            multicastMessage += showMessage4;
            multicastMessage("Đây là Multicast Delegates");

            Console.WriteLine("----Trừ trong Multicast Delegates-----");
            multicastMessage = multicastMessage - showMessage4;
            multicastMessage("Đây là trừ trong DELEGATE");

            //*P4: Delegate Callback trong hàm Main
            Console.WriteLine("=====P4: Delegate Callback trong hàm Main=====");
            DelegateCallback a = new DelegateCallback(showMess);
            Callback(a);
        }
        //*P4: Delegate Callback ngoài hàm Main
        public delegate void DelegateCallback(string mess);
        public static void showMess(string mess)
        {
            Console.WriteLine("==> Thông báo: " + mess);
        }
        public static void Callback(DelegateCallback delegateCallback)
        {
            Console.Write("Mời bạn nhập thông báo: ");
            var temp = Console.ReadLine();
            delegateCallback(temp);
        }
    }
}
