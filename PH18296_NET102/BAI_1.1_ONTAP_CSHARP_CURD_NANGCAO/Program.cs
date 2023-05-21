using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP_CURD_NANGCAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Console.InputEncoding = Encoding.UTF8;

            IServiceStudent cn = new ServiceStudent();
            cn.addStudentDungna();
            cn.getListStudent();
            cn.removeStudent();
        }
    }
}
