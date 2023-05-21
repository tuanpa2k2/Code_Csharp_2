using System;
using System.Text;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            ClassNested.ClassD classD = new ClassNested.ClassD();
            classD.Variable1 = "";
            classD.method1();

            ClassA classA = new ClassA();
            classA.variableA = "";
            classA.variableB = "";
            classA.variableC = 1;
            classA.variableD = 1;
            classA.method1();
            classA.method2();
            classA.method3();
        }
    }
}
