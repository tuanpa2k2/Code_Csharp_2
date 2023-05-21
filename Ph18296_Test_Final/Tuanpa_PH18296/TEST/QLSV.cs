using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TEST
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private List<SinhVien> _newSinhVien = new List<SinhVien>();
        private SinhVien _sinhVien;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string path = @"E:\C#_2\Ph18296_Test_Final\Tuanpa_PH18296\TEST\data.bin";
        public QLSV()
        {
            _sinhVien = new SinhVien(1, "Tuấn", 2002, 9, 1);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(2, "Tùng", 2005, 4, 1);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(3, "Thảo", 2000, 9, 2);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(4, "Anh", 2002, 9, 2);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(5, "Văn", 2002, 5, 3);
            _lstSinhViens.Add(_sinhVien);
        }
        private string GetValueInput(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        public static bool CheckSo(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }
        public static int CheckSoValue(string soo)
        {
            string so;
            do
            {
                Console.Write("Mời bạn nhập " + soo);
                so = Console.ReadLine();
            } while (!CheckSo(so));
            int kq = Convert.ToInt32(so);
            return kq;
        }

        //////-----------------//////////
        public void AddSinhVien()
        {
            _input = GetValueInput("số lượng cần thêm: ");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                Console.WriteLine("Thông tin sinh viên " + (i + 1) + ":");
                _sinhVien = new SinhVien();
                _sinhVien.Masv = CheckSoValue("Mã sv: ");
                _sinhVien.Tensv = GetValueInput("Tên sv: ");
                _sinhVien.NamSinh = CheckSoValue("Năm sinh: ");
                _sinhVien.DiemC = Convert.ToDouble(GetValueInput("Điểm C#: "));
                _sinhVien.GioiTinh = CheckSoValue("Giới tính (1: Nam | 2: Nữ): ");

                _lstSinhViens.Add(_sinhVien);
            }
            Console.WriteLine("==> Add thành công !");
        }
        public void GetListSinhVien()
        {
            Console.WriteLine(" ...Danh sách sinh viên...");
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHinh();
            }
        }
        public void OpenFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                _lstSinhViens = new List<SinhVien>();
                _lstSinhViens = (List<SinhVien>)data;
                _fs.Close();
                Console.WriteLine("==> Mở file thành công !");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Mở file thất bại !");
        }
        public void SaveFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, _lstSinhViens);
                _fs.Close();
                Console.WriteLine("==> Lưu file thành công !");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Lưu file thất bại !");
        }
        public void RemoveSinhVien()
        {
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHinh();
            }
            _input = GetValueInput("Mã sv cần xóa: ");
            _lstSinhViens.RemoveAt(_lstSinhViens.FindIndex(c => c.Masv == Convert.ToInt32(_input)));
            Console.WriteLine("==> Xóa thành công !");
        }
        public void LocSinhVien()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(" ...Danh sách sinh viên...");
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHinh();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("! Danh sách SV có: ( Tên bắt đầu bằng chữ 'T', có điểm C# >= 5, Tuổi > 20 ).\n");
            var lst = _lstSinhViens.Where(c => c.Tensv.StartsWith("T"));
            foreach (var x in lst)
            {
                if (DateTime.Now.Year - x.NamSinh > 20 && x.DiemC >= 5)
                {
                    x.InRaManHinh();
                }
            }
        }
        public void SortSinhVien()
        {
            _newSinhVien = _lstSinhViens.OrderByDescending(c => c.Tensv).ToList();
            _lstSinhViens.Clear();
            _lstSinhViens = _newSinhVien;
            Console.WriteLine("==> Sắp xếp thành công !");
        }
    }
}
