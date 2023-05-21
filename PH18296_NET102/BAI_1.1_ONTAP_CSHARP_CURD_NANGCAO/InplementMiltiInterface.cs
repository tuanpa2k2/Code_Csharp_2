using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP_CURD_NANGCAO
{
    interface IService1
    {
        void method1();
    }
    interface IService2
    {
        void method3();
    }

    //Trong lập trình 1 con chỉ có 1 cha
    //Nhưng cũng có thể implement nhiều Interface
    class Service : IService1, IService2
    {
        public void method1()
        {
            throw new NotImplementedException();
        }

        public void method3()
        {
            throw new NotImplementedException();
        }
    }
}
