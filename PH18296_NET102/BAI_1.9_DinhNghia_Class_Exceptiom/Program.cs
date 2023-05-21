using System;
using System.Text;

namespace BAI_1._9_DinhNghia_Class_Exceptiom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            try
            {
                dangkyClubCsharp(null, 20);
            }
            catch (NameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();//Là phương thức bên trong đối tượng AgeException
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void dangkyClubCsharp(string ten, int tuoi)
        {
            if (string.IsNullOrEmpty(ten))
            {

                throw new NameException("Tên không được phép null");
            }

            if (tuoi < 18)
            {
                throw new AgeException("Bạn chưa đủ tuổi vào Club C# nhé", tuoi);
            }
            Console.WriteLine("Chào mừng bạn đến với Club C# " + ten + " " + tuoi);
        }
    }
}
