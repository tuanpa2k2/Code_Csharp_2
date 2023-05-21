using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_4._5
{
    class ServiceStudent
    {
        static private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private SinhVien _sinhViens;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;

        
        public ServiceStudent()
        {
            _sinhViens = new SinhVien(0, "PH1", "TUAN", 1, 3, true);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien(1, "PH2", "THAO", 2, 1, false);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien(2, "PH3", "THI", 3, 2, true);
            _lstSinhViens.Add(_sinhViens);
            _sinhViens = new SinhVien(3, "PH4", "THU", 2, 3, false);
            _lstSinhViens.Add(_sinhViens);
        }
        private string GetValueInput(string mess)
        {
            Console.Write("Mời bạn nhập "+ mess);
            return Console.ReadLine();
        }
        private int GetIndexMaSv(string maStudent)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Masv == Convert.ToString(maStudent)) 
                {
                    return i;
                }
            }
            return -1;
        }
        
        //code
        public void AddStudent()
        {
            do
            {
                _input = GetValueInput("số lượng sinh viên cần thêm: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("Thông tin sinh viên thứ " + (i + 1) + ":");
                    _sinhViens = new SinhVien();
                    _sinhViens.Id = _lstSinhViens.Count;
                    _sinhViens.Masv = GetValueInput("mã sinh viên: ");
                    _sinhViens.Ten = GetValueInput("tên sinh viên: ");
                    _sinhViens.NganhHoc = Convert.ToInt32(GetValueInput("ngành học (1: UDPM | 2: WEB | 3: MOB): "));
                    _sinhViens.TrangThai = Convert.ToInt32(GetValueInput("trạng thái học (1: HỌC LẠI | 2: HỌC ĐI | 3: THÔI HỌC): "));
                    _sinhViens.GioiTinh = Convert.ToBoolean(GetValueInput("trạng thái học (true: Nam | false: Nữ): "));

                    _lstSinhViens.Add(_sinhViens);
                }
                Console.Write("Bạn có muốn nhập tiếp không (n: Không | y: Có) ?:  ");
                _input = Console.ReadLine();
            } while (!(_input.ToLower() == "n"));
            Console.WriteLine("==> THANK YOU ...!");
        }
        public void UpdateStudent()
        {
            P:
            _input = GetValueInput("mã sinh viên cần update thông tin: ");
            int temp = GetIndexMaSv(_input);
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại, Vui lòng nhập lại !");
                goto P;
            }
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Masv == Convert.ToString(_input))   
                {
                J:
                    Console.Clear();
                    Console.WriteLine("Các thông tin được phép sửa : ");
                    Console.WriteLine(" 1: Tên sinh viên: \t\t\t\t\t" + _lstSinhViens[i].Ten);
                    Console.WriteLine(" 2: Ngành học sinh viên (1: UDPM | 2: WEB | 3: MOB): \t" + _lstSinhViens[i].NganhHoc);
                    Console.WriteLine(" 3: Trạng thái (1: HỌC LẠI | 2: HỌC ĐI | 3: THÔI HỌC): \t" + _lstSinhViens[i].TrangThai);
                    Console.WriteLine(" 4: Giới tính (true: Nam | false: Nữ): \t\t\t" + _lstSinhViens[i].GioiTinh);
                    Console.WriteLine(" 0: THOÁT ...");
                    _input = GetValueInput("phần cần Update: ");
                    switch (_input)
                    {
                        case "1":
                            _lstSinhViens[i].Ten = GetValueInput("tên cần sửa: ");
                            break;
                        case "2":
                            _lstSinhViens[i].NganhHoc = Convert.ToInt32(GetValueInput("ngành học cần sửa: "));
                            break;
                        case "3":
                            _lstSinhViens[i].TrangThai = Convert.ToInt32(GetValueInput("trạng thái học cần sửa: "));
                            break;
                        case "4":
                            _lstSinhViens[i].GioiTinh = Convert.ToBoolean(GetValueInput("giới tính cần sửa: "));
                            break;
                        case "0":
                            Console.WriteLine("==> Thank you ...");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto J;
                    }
                    Console.WriteLine("==> Update thành công !");
                }
            }
        }
        public void RemoveStudent()
        {
            int temp = GetIndexMaSv(GetValueInput("mã sinh viên cần xóa: "));
            if (temp == -1)
            {
                Console.WriteLine("Mã sinh viên không tồn tại !");
                return;
            }
            _lstSinhViens.RemoveAt(temp);
            Console.WriteLine("Xóa thành công !");
        }
        public void GetlistStudent()
        {
            Console.WriteLine("Danh sách Student :");
            foreach (var x in _lstSinhViens)
            {
                x.InRaManHinh();
            }
        }
        public void LocNganh()
        {
            _input = GetValueInput("nhập ngành cần lọc (1: UDPM | 2: WEB | 3: MOB): ");
            bool flag = true;
            foreach (var x in _lstSinhViens.Where(c => c.NganhHoc == Convert.ToInt32(_input)))
            {
                x.InRaManHinh();
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Tên cần lọc không có trong danh sách, Vui lòng nhập lại !");
            }
        }
        public void LocTrangThai()
        {
            G:
            _input = GetValueInput("nhập ngành cần lọc (1: HỌC LẠI | 2: HỌC ĐI | 3: THÔI HỌC): ");
            bool flag = true;
            foreach (var x in _lstSinhViens.Where(c => c.TrangThai == Convert.ToInt32(_input)))
            {
                x.InRaManHinh();
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Tên cần lọc không có trong danh sách, Vui lòng nhập lại !");
                goto G;
            }
        }
        public void MoFile()
        {
            string path = @"C:\Poly_c#\lab4_5.txt"; 
            StreamReader sr = new StreamReader(path);
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();
        }
        public void GhiFile(string path)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, _lstSinhViens);
            _fs.Close();
            System.Console.WriteLine("Ghi thành công");
        }
        public List<SinhVien> GetListStudents()
        {
            return _lstSinhViens;
        }
        //public void LuuFile()
        //{
        //    using (StreamWriter sw = new StreamWriter(@"C:\Poly_c#\tuanpa.txt"))
        //    {
        //        foreach (var s in _lstSinhViens)
        //        {
        //            sw.WriteLine(s.GetHashCode());
        //        }
        //    }
        //    Console.WriteLine("==> Lưu FILE thành công !");
        //}
        //public void DocFileTest (string path)
        //{
        //    _fs = new FileStream(path, FileMode.Open);
        //    _bf = new BinaryFormatter();//Khởi tạo
        //    var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
        //    _lstSinhViens = new List<SinhVien>();
        //    _lstSinhViens = (List<SinhVien>)data;//Gán lại List object cho List Student
        //    _fs.Close();
        //}
    }
}
