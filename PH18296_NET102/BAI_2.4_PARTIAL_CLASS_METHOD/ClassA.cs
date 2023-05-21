using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    partial class ClassA // them tu khoa "partial" vao trc.
    {
        public string variableA { get; set; }
        public string variableB { get; set; }
        public void method1()
        {
            Console.WriteLine("Đây là phương thức method 1");
        }
        public partial void method3(); // giống như astract, k có thân code, chỉ để khai báo
    }
}
