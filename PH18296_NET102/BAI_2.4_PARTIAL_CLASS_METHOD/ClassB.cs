﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._4_PARTIAL_CLASS_METHOD
{
    partial class ClassA    //classA nằm trong file ClassB
    {
        public double variableC { get; set; }
        public double variableD { get; set; }
        public void method2()
        {
            Console.WriteLine("Đây phương thức là method 2");
        }
        public partial void method3()
        {
            Console.WriteLine("Đây là phương thức Method 3");
        }
    }
}
