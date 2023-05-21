using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace A_TUANPAPH18296
{
    class QLSV
    {
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private List<SinhVien> _newSinhVien = new List<SinhVien>();
        private SinhVien _sinhViens;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string path = @"E:\C#_2\PH18296_NET102\A_TUANPAPH18296\data.bin";
        public QLSV()
        {
            _sinhViens = new SinhVien("PH18296", "Tuấn", 2002);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien("PH18297", "Thảo", 2001);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien("PH18296", "Huy", 2003);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien("PH18295", "Hùng", 1999);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien("PH18291", "Anh", 1999);
            _lstSinhViens.Add(_sinhViens);

        }
        private string GetValueInput(string mess)
        {
            do
            {
                Console.Write("Mời bạn nhập " + mess);
                return Console.ReadLine();
            } while (!checkSo1(_input));
            
        }
        private int GetMaSinhVien(string maSV)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Ten == maSV)
                {
                    return i;
                }
            }
            return -1;
        }
        //Code
        public bool checkSo1(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }
        public void checkSo()
        {
            do
            {
                Console.Write("Mời bạn nhập số: ");
                _input = Console.ReadLine();
            } while (!checkSo1(_input));
        }

        public void AddSinhVien()
        {
            do
            {
                _input = GetValueInput("số lượng cần thêm: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("Thông tin sinh viên thứ " + (i + 1) + ":");
                    _sinhViens = new SinhVien();
                    _sinhViens.Masv = GetValueInput("mã sinh viên: ");
                    _sinhViens.Ten = GetValueInput("tên sinh viên: ");
                    _sinhViens.NamSinh = Convert.ToInt32(GetValueInput("năm sinh sinh viên: "));

                    _lstSinhViens.Add(_sinhViens);
                }
                Console.Write("Bạn có muốn nhập tiếp k (y: Có | n: Không): ");
                _input = Console.ReadLine();
            } while (!checkSo1(_input));
        }
        public void GetListSinhVien()
        {
            Console.WriteLine("Danh sách sinh viên :");
            foreach (var x in _lstSinhViens)
            {
                x.inRaManHinh();
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
        X:
            int temp = GetMaSinhVien(GetValueInput("mã sinh viên cần xóa: "));
            if (temp == -1)
            {
                Console.WriteLine("==> Mã sinh viên không tồn tại !");
                goto X;
            }
            _lstSinhViens.RemoveAt(temp);
            Console.WriteLine("==> Xóa thành công !");
        }
        public void LocSinhVien()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            var lst = _lstSinhViens.Where(c => c.Ten.StartsWith("H"));
            foreach (var x in lst)
            {
                if (DateTime.Now.Year - x.NamSinh <= 20)
                {
                    x.inRaManHinh();
                }
            }
        }
        public void SortSinhVien()
        {
            _newSinhVien = _lstSinhViens.OrderByDescending(c => c.Ten).ToList();
            _lstSinhViens.Clear();
            _lstSinhViens = _newSinhVien;
            Console.WriteLine("Sắp xếp thành công !");
            foreach (var x in _lstSinhViens)
            {
                x.inRaManHinh();
            }
        }

    }
}
