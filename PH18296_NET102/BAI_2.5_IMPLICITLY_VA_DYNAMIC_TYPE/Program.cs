using System;
using System.Text;

namespace BAI_2._5_IMPLICITLY_VA_DYNAMIC_TYPE
{
    class Program
    {
        static void Main(string[] args)
        {
            //*1. Khai báo
            var a = 50; //Implicitly typed
            int b = 50; //Explicitly typed
            var c = true; //
                          //*2. Hạn chế khi khai báo và xảy ra lỗi:
                          //- Không thể khởi tạo giá trị null
                          // var temp = null;
                          //- Phải khởi tạo ngay sau khi khai báo biến
                          // var temp;
                          //- Nếu biến đc gán gtri thì kiểu dữ liệu phải giống nhau
                          // var temp = 5;
                          // temp = "1";
                          //- 
                          //var arrNumber = {10, 5, 8} --lỗi , muốn chạy đc thì phải thêm "new"
                          //var arrNumber = new int[] { 1, 2, 3 };
                          //- Không thể khai báo bên ngoài phương thức và k thể dùng nó làm tham số truyền vào của 1 Method
            var student = new
            {
                id = "PH18296",
                name = "Tuan",
                nganhHoc = "UDPM.NET"
            };
            //goi
            method2(student, student.name); 
        }
        private dynamic a;
        static void method2(dynamic tem1, dynamic tem2)
        {
            Console.WriteLine(tem2 + " " + tem1.id);
        }

    }
}
