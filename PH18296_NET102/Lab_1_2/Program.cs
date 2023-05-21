using System;
using System.Text;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceTiVi cn = new ServiceTiVi();

            int n;
        T:
            Console.Clear();
            Console.WriteLine("MENU chức năg :");
            Console.WriteLine("1: Add tivi");
            Console.WriteLine("2: Update tivi");
            Console.WriteLine("3: Remove tivi");
            Console.WriteLine("4: Find tivi");
            Console.WriteLine("0: Out Menu ");
            Console.Write("Mời bạn chọn chức năng: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.Clear();
                    cn.addTivi();
                    cn.getListTivi();
                    Console.ReadKey();
                    goto T;
                case 2:
                    Console.Clear();
                    cn.getListTivi();
                    cn.updateTivi();
                    Console.ReadKey();
                    goto T;
                case 3:
                    Console.Clear();
                    cn.getListTivi();
                    cn.removeTivi();
                    Console.ReadKey();
                    goto T;
                case 4:
                    Console.Clear();
                    cn.getListTivi();
                    cn.findTivi();
                    Console.ReadKey();
                    goto T;
                case 0:
                    Console.WriteLine(" ==> Thank You ^_^ ...");
                    break;
                default:
                    Console.WriteLine("==> Bạn chọn sai chức năng, Vui lòng nhập lại !");
                    Console.ReadKey();
                    goto T;
            }
        }
    }
}
