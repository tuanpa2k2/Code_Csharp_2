using System;

namespace BAI_2._6_NULLLABLE_TYPED
{
    class Program
    {
        class ClassA
        {
            public void method1()
            {
                Console.WriteLine("Method 1 Class A");
            }
        }
        static void Main(string[] args)
        {
            #region Phan1: Null
            ClassA classA1, classA2;

            classA1 = new ClassA(); //ClassA1 được khởi tạo
            classA2 = classA1;      //Class A2 đc gán bởi ClassA1

            classA1 = null;
            classA1.method1();

            #endregion
            #region Phần 2: lớp Nullable Typed
            Nullable<long> temp3 = null;
            Nullable<long> temp4 = 9;
            byte? temp5 = 20;
            byte?[] arr = new byte?[5];

            if (temp4.HasValue.HasValue)
            {
            }
            Console.WriteLine(temp3.GetValueOrDefault());
            byte? temp6 = null;
            byte temp7 = temp6 ?? 0;

            #endregion
        }
    }
}
