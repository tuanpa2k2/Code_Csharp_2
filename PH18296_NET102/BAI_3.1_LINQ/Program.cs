using System;
using System.Linq;

namespace BAI_3._1_LINQ
{
    class Program
    {
        #region Linq là gì ?
        /*
       *  LINQ: Language Integrated Query
       *  Định nghĩa:  ngôn ngữ truy vấn tích hợp - nó tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) vào bên trong ngôn ngữ lập trình C#, 
            cho nó khả năng truy cập các nguồn dữ liệu khác nhau (SQL Db, XML, List ...) với cùng cú pháp.
       * Ưu điểm:
         ➢ Ưu điểm lớn nhất của Linq đó chính là sự mạch lạc trong code, xậy dựng nhanh, ít gây lỗi
         ➢ Linq cung cấp nhiều phương thức trong truy vấn dữ liệu, nếu cùng một chức năng, khi sử dụng truy vẫn thuần có thể phải code nhiều gấp 
                2, 3 lần khi sử dụng linq (tùy ứng dụng)
         ➢ Cách tiếp cận khai báo giúp truy vấn dễ hiểu và gọn hơn
       * Nhược điểm:
        ➢ Tốc độ chậm nếu viết linq không khéo
          Linq query systax:
                              from object in datasource
                              where condition
                              select object
          from: Từ nguồn dữ liệu mà truy vấn sẽ thực hiện
          in: bên trong nguồi giá trị nào
          datasource: tập giá trị nguồn
          where: lọc dữ liệu theo điều kiện condition
          select object: Lấy ra kết quả có thể là giá trị hoặc tập giá trị
          Ngoài ra chúng ta cũng thấy việc áp dụng lambda cơ bản với những câu lọc dữ liệu ngắn sẽ đơn giản nhưng khi join vào nhiều datasource sẽ không dễ đọc với người chưa có kinh nghiệm
       */
        #endregion
        static void Main(string[] args)
        {
            string[] arrName = { "Hoa", "Trang", "Dũng", "Long", "Mạnh", "Hoàng", "Tùng", "Lan" };
            int[] arrNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //vd_1: Lấy ra tên ng có 4 từ trở lên
            var lstName4Tu = (from a in arrName
                              where a.Length > 4
                              select a).ToList();//.toList: đổi về listString, trả về kiểu list 
            var lstName4Tu2 = arrName.Where(c => c.Length > 4).Select(c => c);
            //==> In ra man hinh
            foreach (var x in lstName4Tu)
            {
                Console.WriteLine(x + " ");
            }
            //vd_2: Lấy ra danh sách số lẻ trong mảng
            var lstSoLe = from a in arrNumber
                          where a % 2 != 0 //( a % 2 != 0 : laf in ra số lẻ,  a % 2 = 0 : Là in ra số chẵn )
                          select a;
            //=> In ra man hinh
            foreach (var x in lstSoLe)
            {
                Console.WriteLine(x + " ");
            }
            //vd_3:
            var lstAsc = from a in arrNumber
                         orderby a //ascending code thừa vì mặc định là ASC 
                         select a;
            var lstDesc = from a in arrNumber
                         orderby a descending
                         select a;

        }
    }
}
