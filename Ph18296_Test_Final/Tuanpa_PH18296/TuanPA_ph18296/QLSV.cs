using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TuanPA_ph18296
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private List<SinhVien> _newSinhViens = new List<SinhVien>();
        private SinhVien _sinhVien;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string path = @"E:\C#_2\Ph18296_Test_Final\Tuanpa_PH18296\TuanPA_ph18296\data.bin";

        public QLSV()
        {
            _sinhVien = new SinhVien(1, "Tuấn", 2002, 8, 1);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(2, "Tung", 2000, 8, 2);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(3, "Thảo", 2001, 4, 1);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(4, "Anh", 2003, 8, 2);
            _lstSinhViens.Add(_sinhVien);
            _sinhVien = new SinhVien(5, "Hùng", 2002, 8, 1);
            _lstSinhViens.Add(_sinhVien);
        }
        private string GetValueInput(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        
        //-----------------------------------------------------------------------------------------------------------------
        public static bool CheckSo(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }
        public static bool CheckChu(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }
        public static int GetCheckSoValue(string messs)
        {
            string so;
            do
            {
                Console.Write("Mời bạn nhập " + messs);
                so = Console.ReadLine();
            } while (!CheckSo(so));
            int kq = Convert.ToInt32(so);
            return kq;
        }
        public static int GetCheckChuValues(int aaa)
        {
            string chu;
            do
            {
                Console.Write("Mời bạn nhập " + aaa);
                chu = Console.ReadLine();
            } while (!CheckChu(chu));
            int kq = Convert.ToInt32(chu);
            return kq;
        }

        //-----------------------------------------------------------------------------------------------------------------
        public void AddSinhVien()
        {
            _input = GetValueInput("số lượng cần thêm: ");
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                Console.WriteLine("Thông tin sinh viên thứ " + (i + 1) + ":");
                _sinhVien = new SinhVien();
                _sinhVien.Masv = GetCheckSoValue("mã SV: ");
                _sinhVien.Tensv = GetValueInput("tên SV: ");
                _sinhVien.NamSinh = GetCheckSoValue("năm sinh: ");
                _sinhVien.DiemC = Convert.ToDouble(GetValueInput("điểm C#: "));
                _sinhVien.GioiTinh = GetCheckSoValue("giới tính(1: Nam | 2: Nữ): ");

                _lstSinhViens.Add(_sinhVien);
            }
            Console.WriteLine("==> Thêm thành công !");
        }
        public void GetListSinhVien()
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHinh();
            }
        }
        public void DocFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                _lstSinhViens = new List<SinhVien>();
                _lstSinhViens = (List<SinhVien>)data;
                _fs.Close();
                Console.WriteLine("==> Đọc file thành công !");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Đọc file thất bại !");
        }
        public void GhiFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, _lstSinhViens);
                _fs.Close();
                Console.WriteLine("==> Ghi file thành công !");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Ghi file thất bại !");
        }
        public void RemoveSinhVien()
        {
            _input = GetValueInput("mã SV cần xóa: ");
            _lstSinhViens.RemoveAt(_lstSinhViens.FindIndex(c => c.Masv == Convert.ToInt32(_input)));
            Console.WriteLine("==> Xóa thành công !");
        }
        public void SortSinhVien()
        {
            _newSinhViens = _lstSinhViens.OrderByDescending(c => c.Tensv).ToList();
            _lstSinhViens.Clear();
            _lstSinhViens = _newSinhViens;
            Console.WriteLine("==> Sắp xếp thành công !");
        }
        public void LocSinhVien()
        {
            Console.WriteLine("------------------------------------------------------------");
            var lst = _lstSinhViens.Where(c => c.Tensv.StartsWith("T"));
            foreach (var x in lst)
            {
                _newSinhViens = _lstSinhViens.OrderByDescending(c => c.Tensv).ToList();
                _lstSinhViens.Clear();
                _lstSinhViens = _newSinhViens;
                x.InRaManHinh();
            }
        }
    }
}
