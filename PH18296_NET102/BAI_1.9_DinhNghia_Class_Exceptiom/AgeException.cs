using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._9_DinhNghia_Class_Exceptiom
{
    class AgeException : Exception
    {
        //prop cách gọi nhanh
        public int Age { get; set; }

        public AgeException(string? message, int age) : base(message)
        {
            Age = age;
        }

        public void Detail()
        {
            Console.WriteLine("Bạn cần thêm vài năm nữa để đủ tuổi nhé");
        }
    }
}
