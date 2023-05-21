using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace BAI_3._2_LINQ_CacCauLenh
{
    class Program
    {
        private static ServiceAll sa = new ServiceAll();
        private static List<NhanVien> _lstNhanViens;
        private static List<SanPham> _lstSanPhams;
        private static List<TheLoai> _lsttTheLoais;
        public Program()
        {
            _lstNhanViens = sa.GetListNhanViens();
            _lstSanPhams = sa.GetListSanPhams();
            _lsttTheLoais = sa.GetListTheLoais();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Program program = new Program();
            ViduGroupBy();
        }
        #region 1. Toán tử Where để lọc theo điều kiện trả về 1 danh sách hoặc 1 giá trị sau khi thỏa mãn điều kiện
        public static void ViduWhere()
        {
            //Lọc danh sách những người có đầu số sau
            var lst = from a in _lstNhanViens //a: đại diện cho 1 đối tượng trong lít
                      where a.Sdt.StartsWith("098") || a.Sdt.StartsWith("08")
                      select a;
            var lst1 = _lstNhanViens.Where(a => a.Sdt.StartsWith("098") || a.Sdt.StartsWith("08")).Select(c => c.Sdt);
            foreach (var x in lst)
            {
                x.InRaManHinh();
            }
            Console.WriteLine("---------------------------");
            foreach (var x in lst1)
            {
                Console.WriteLine(x);
            }
        }
        #endregion
        #region 2. Toán tử OfType để lọc theo điều kiện lọc một phần tử trong tập hợp thành một kiểu được chỉ định
        public static void ViduOfType()
        {
            ArrayList arrayTemp = new ArrayList();
            arrayTemp.Add("Tám");
            arrayTemp.Add(9);
            arrayTemp.Add("Chín");
            arrayTemp.Add(8);
            var lstTemp1 = from a in arrayTemp.OfType<string>() //OfType: lọc dữ liệu theo kiểu mk mong muốn
                           select a;
            var lstTemp2 = from a in arrayTemp.OfType<int>()
                           select a;
            Console.WriteLine("arrayTemp.OfType<string>() ... ");
            foreach (var x in lstTemp1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("arrayTemp.OfType<int>() ...");
            foreach (var x in lstTemp2)
            {
                Console.WriteLine(x);
            }
        }
        #endregion
        #region 3. OrderBy sử dụng để sắp xếp danh sách theo một điều kiện cụ thể
        public static void ViDuOrderBy()
        {
            //*Đề bài: Lấy ra  1 danh sách nhân viên đc sắp xếp tăng dần
                //Cách dùng Linq.
            var temp = from a in _lstNhanViens
                       orderby a.TenNV  // ascending || descending
                       select a;
            //Cách dùng Lambda
            var temp2 = _lstNhanViens.OrderBy(c => c.TenNV);
        }
        public static void ViDuThenBy()
        {
            //*Đề bài: Lấy ra  1 danh sách nhân viên đc sắp xếp tăng dần
            var temp2 = _lstNhanViens.OrderBy(c => c.TenNV).ThenBy(c =>c.ThanhPho).ThenBy(c => c.Sdt);
            var temp3 = _lstNhanViens.OrderBy(c => c.TenNV).ThenByDescending(c => c.ThanhPho).ThenBy(c => c.Sdt);
            //--ThenBy: Sắp xếp thêm nhiều trường mà mk muốn.
        }
        #endregion
        #region 4. GroupBy nhóm các phần giống nhau
        public static void ViduGroupBy()
        {
            //1. GroupBy: nhóm các thành phần giống nhau.
            List<string> lstName = new List<string> { "Trang", "Trang", "Kiều", "Kiều", "A", "B", "C", "A" };
            var temp1 = from a in lstName
                        group a by a
                        into g //into: nhóm lại tất cả các cái giống nhau, g: là đại diện cho giá trị mới, kiểu dl mới sau khi nhóm
                        select g.Key;
            //foreach (var x in temp1)
            //{
            //    Console.Write(x + " ");
            //}
            //2. Lấy ra dsach thể loại trong bảng sản phẩm
            var temp2 = from a in _lstSanPhams
                        group a by a.IdTheLoai
                        into g
                        select g.Key;
            //foreach (var x in temp2)
            //{
            //    Console.Write(x + " ");
            //}
            //3. 
            //SD linq...
            var temp3 = from a in _lstSanPhams
                        group a by new //Nhóm khi cùng thỏa mãn 2 điều kiện dưới đây
                        {
                            a.IdTheLoai,
                            a.TrangThai
                        }
                        into g
                        select new SanPham()
                        {
                            IdTheLoai = g.Key.IdTheLoai,
                            TrangThai = g.Key.TrangThai,
                            SoLuongTrangThai = g.Count(c => c.TrangThai == c.TrangThai),
                            SoLuongTheLoai = g.Count(c => c.IdTheLoai == c.IdTheLoai)
                        };
            //foreach (var x in temp3)
            //{
            //    Console.WriteLine(x.IdTheLoai + " " + x.TrangThai + 
            //        " SL Trạng thái: " + x.SoLuongTrangThai +
            //        " SL thể loại: " + x.SoLuongTheLoai);
            //}

            //SD lambda...
            var temp4 = _lstSanPhams.GroupBy(a => new { a.IdTheLoai, a.TrangThai }).Select(g => new
            {
                IdTheLoai = g.Key.IdTheLoai,
                TrangThai = g.Key.TrangThai,
                SoLuongTrangThai = g.Count(c => c.TrangThai == c.TrangThai),
                SoLuongTheLoai = g.Count(c => c.IdTheLoai == c.IdTheLoai)
            });
            foreach (var x in temp4)
            {
                Console.WriteLine(x.IdTheLoai + " " + x.TrangThai + " SLTrạng thái: " + x.SoLuongTrangThai +
                    " SLthể loại: " + x.SoLuongTheLoai);
            }
            //Khi sử dụng Groupby khi cần nhóm các cột dữ liệu giống nhau tạo thành các bản ghi mới và thường đi với các hàm tổng hợp

            //Buổi sau code lại câu đếm số lượng nhân viên sống tại HN sử dụng Groupby
            //Tính tổng giá bán của các sản phẩm có cùng thể loại

        }
        #endregion
    }
}
