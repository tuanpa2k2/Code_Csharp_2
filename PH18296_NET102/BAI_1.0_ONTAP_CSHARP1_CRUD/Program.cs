using System;
using System.Text;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            //Student student = new Student(); // new Student(); là tạo conctructer k tham số ban đầu nếu khi mk chưa tạo ở phần class

            //student.Id = 1; // .Id là chỉ đến Property và gán cho nó bằng 1
            //Console.WriteLine(student.Id);

            ChucNang cn = new ChucNang();
                cn.addStudentRutGon();
                Console.WriteLine("--------------------------------------------------------");
                cn.getListStudent();
        }
    }
}
