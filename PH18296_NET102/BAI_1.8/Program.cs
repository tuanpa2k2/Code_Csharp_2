using System;
using System.Text;

namespace BAI_1._8
{
    class Program
    {
        #region Phần 1: Định nghĩa ra 1 EXCEPTION bên trong 1 phương thức 
        static void dangKiClupCsharp(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            {
                Exception exception = new Exception("Tên k được để Null nhé !");
                throw exception;
            }
            if (tuoi < 18)
            {
                throw new Exception("Bạn chưa đủ tuổi vào Club nhé !");
            }
            Console.WriteLine("Chào mừng bạn đến với Club C#" + ten + " " + tuoi);
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangKiClupCsharp("Tuan", 12);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
