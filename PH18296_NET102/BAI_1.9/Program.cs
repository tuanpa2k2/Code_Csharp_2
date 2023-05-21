using System;
using System.Text;

namespace BAI_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

        }
        static void dangKiClupCsharp(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            {
                throw new NameException("Tên k được để Null nhé !");
            }
            if (tuoi < 18)
            {
                throw new Exception("Bạn chưa đủ tuổi vào Club nhé !");
            }
            Console.WriteLine("Chào mừng bạn đến với Club C#" + ten + " " + tuoi);
        }
    }
}
