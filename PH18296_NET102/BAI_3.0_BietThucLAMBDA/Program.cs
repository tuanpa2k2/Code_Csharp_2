using System;

namespace BAI_3._0_BietThucLAMBDA
{
    class Program
    {
        #region Lambda
        /*
        * Biểu thức lambda còn gọi là biểu thức (Anonymous), một biểu thức khai báo giống phương thức nhưng thiếu tên. 
            Cú pháp để khai báo biểu thức lambda là sử dụng toán dử => như sau:
          Công thức 1:
               (tham_số) => biểu_thức;
          Công thức 2:
           (tham_số) =>
               {
                  các câu lệnh
                  Sử dụng return nếu có giá trị trả về
               }            
        */
        //VD_1: Sd delegate với Lambda
        delegate int TimHieu(int a, int b);
        public static void Vd1()
        {
            int a = 8, b = 2;
            TimHieu timHieu = (int c, int d) =>
            {
                return c - d;
            };
            TimHieu timHieu2 = (int c, int d) => c - d; //Cách 2
            Console.WriteLine(timHieu2(a, b));  // Chạy
        }

        //Vd_2: Khai báo 1 phương thức kiểu lambda
        static double PhepChia(int x, int y) => x / y;

        //Vd_3:
        public static void Vd3()
        {
            int[] arrNumber = { 11, 22, 33, 44, 55 };
            //c1: in ra
            Array.ForEach(arrNumber, delegate (int x) { Console.WriteLine(x + " "); });
            //c2:
            Array.ForEach(arrNumber, x => Console.WriteLine(x + " "));
            //c3:
            foreach (var x in arrNumber) Console.WriteLine(x + " ");
        }
        #endregion

        #region Một số quy tắc sd Lambda
        delegate void ChaoBan1(string name);
        delegate void ChaoBan2();
        delegate void ChaoBan3(string name1, string name2, string name3);
        delegate int TinhToan(int a, int b);
        delegate bool Check1(int a, int b);

        static void Vd4()
        {
            //1. Không quan tâm đến kiểu dữ liệu đầu vào
            ChaoBan1 chao1 = (string temp) => { Console.WriteLine("Chào bạn " + temp); };
            ChaoBan1 chao2 = (temp) => { Console.WriteLine("Chào bạn " + temp); };

            //2. Để trống nếu không có tham số
            ChaoBan2 chao3 = () => { Console.WriteLine("Chào bạn "); };

            //3. Nếu chỉ có 1 tham số thì bỏ luôn dấu ngoặc
            ChaoBan1 chao4 = temp => { Console.WriteLine("Chào bạn " + temp); };

            //4. Nếu có quá nhiều tham số thì sd dấu , để ngăn cách
            ChaoBan3 chao5 = (x, y, z) => { Console.WriteLine("Chào bạn " + x + y + z); };

            //5. Nếu phương thức có 1 câu lệnh thực thi, thì bỏ luôn dấu {}
            ChaoBan3 chao6 = (x, y, z) => Console.WriteLine("Chào bạn " + x + y + z);

            //6. Đối với phương thức Return
            TinhToan tinhToan = (x, y) => { return x + y; };
            Check1 check1 = (x, y) => { return x > 10 && y < 20; };

        }
        //Ngoài ra các bạn mở rộng kiến thức bằng cách Search nhiều.
        #endregion
        static void Main(string[] args)
        {
            Vd1();
        }
    }
}
