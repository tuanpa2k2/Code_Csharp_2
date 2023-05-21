using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    class ServiceDanhBa
    {
        private List<DanhBa> _lstDanhBas = new List<DanhBa>();
        private List<DanhBa> _newDanhBas = new List<DanhBa>();
        private DanhBa _danhBa;
        private string _input;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string path = @"E:\C#_2\PH18296_NET102\Asignment\data.bin";
        #region Mảng lọc nhà mạng
        private string[] Viettel = new string[] { "086", "096", "097", "098", "032", "033", "034", "035", "036", "037", "038", "039" };
        private string[] Vina = new string[] { "091", "094", "083", "084", "085", "081", "082", "088" };
        private string[] Mobi = new string[] { "089", "090", "093", "070", "079", "077", "076", "078" };
        private string[] ABCD = new string[] { };
        #endregion

        public ServiceDanhBa()
        {
            _danhBa = new DanhBa(0, "PHI", "ANH", "TUAN", 2002, 1, "0365269311", "0399495517", "tuanpaph18296@fpt.edu.vn", "Không có");
            _lstDanhBas.Add(_danhBa);
            _danhBa = new DanhBa(1, "NGUYEN", "ANH", "HUNG", 2001, 2, "0123456", "0399495517", "tuanpaph18296@fpt.edu.vn", "Không có");
            _lstDanhBas.Add(_danhBa);
            _danhBa = new DanhBa(2, "TRAN", "VAN", "BUONG", 2003, 1, "0987654", "0399495517", "tuanpaph18296@fpt.edu.vn", "Không có");
            _lstDanhBas.Add(_danhBa);
            _danhBa = new DanhBa(3, "TRAN", "VAN", "TUAN", 2003, 1, "0377654", "0399495517", "tuanpaph18296@fpt.edu.vn", "Không có");
            _lstDanhBas.Add(_danhBa);
            _danhBa = new DanhBa(4, "TRAN", "VAN", "HUNG", 2003, 1, "0977654", "0399495517", "tuanpaph18296@fpt.edu.vn", "Không có");
            _lstDanhBas.Add(_danhBa);
        }
        private string getValueInput(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        private int getIndexDanhBa(string idDanhBa)
        {
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Id == Convert.ToInt32(idDanhBa))
                {
                    return i;
                }
            }
            return -1;
        }

        //code
        #region Case 1: Thêm - Sửa - Xóa - Sắp xếp - Xuất danh sách.
        public void addDanhBa()
        {
            do
            {
                _input = getValueInput("số lượng người cần thêm vào danh bạ: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    Console.WriteLine("Thông tin người thứ " + (i + 1) + ":");
                    _danhBa = new DanhBa();
                    _danhBa.Id = _lstDanhBas.Count;
                    _danhBa.Ho = getValueInput("họ: ");
                    _danhBa.TenDem = getValueInput("tên đệm: ");
                    _danhBa.Ten = getValueInput("tên: ");
                    _danhBa.NamSinh = Convert.ToInt32(getValueInput("năm sinh: "));
                    _danhBa.GioiTinh = Convert.ToInt32(getValueInput("giới tính (1: Nam || 2: Nữ): "));
                    _danhBa.Sdt1 = getValueInput("sđt_1: ");
                    _danhBa.Sdt2 = getValueInput("sđt_2: ");
                    _danhBa.Email = getValueInput("email: ");
                    _danhBa.GhiChu = getValueInput("ghi chú: ");

                    _lstDanhBas.Add(_danhBa);
                }
                Console.Write("Bạn có muốn nhập tiếp không ? (y || n): ");
                _input = Console.ReadLine();

            } while (!(_input.ToLower() == "n"));
        }
        public void updateDanhBa()
        {
        L:
            _input = getValueInput("id cần sửa: ");
            int temp = getIndexDanhBa(_input);
            if (temp == -1)
            {
                Console.WriteLine("==> Id không tồn tại trong danh bạ, Mời bạn nhập lại !");
                goto L;
            }
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Id == Convert.ToInt32(_input))
                {
                E:
                    Console.Clear();
                    Console.WriteLine("Các thông tin được phép sửa :");
                    Console.WriteLine("1: Sửa họ: \t\t" + _lstDanhBas[i].Ho);
                    Console.WriteLine("2: Sửa tên đệm: \t" + _lstDanhBas[i].TenDem);
                    Console.WriteLine("3: Sửa tên: \t\t" + _lstDanhBas[i].Ten);
                    Console.WriteLine("4: Sửa năm sinh: \t" + _lstDanhBas[i].NamSinh);
                    Console.WriteLine("5: Sửa giới tính (1: NAM || 2: NỮ): " + _lstDanhBas[i].GioiTinh);
                    Console.WriteLine("6: Sửa SĐT_1: \t\t" + _lstDanhBas[i].Sdt1);
                    Console.WriteLine("7: Sửa SĐT_2: \t\t" + _lstDanhBas[i].Sdt2);
                    Console.WriteLine("8: Sửa email: \t\t" + _lstDanhBas[i].Email);
                    Console.WriteLine("9: Sửa ghi chú: \t" + _lstDanhBas[i].GhiChu);
                    Console.WriteLine("0: Thoát !");
                    _input = getValueInput("phần cần sửa: ");
                    switch (_input)
                    {
                        case "1":
                            _lstDanhBas[i].Ho = getValueInput("họ cần sửa: ");
                            break;
                        case "2":
                            _lstDanhBas[i].TenDem = getValueInput("tên đệm cần sửa: ");
                            break;
                        case "3":
                            _lstDanhBas[i].Ten = getValueInput("tên cần sửa: ");
                            break;
                        case "4":
                            _lstDanhBas[i].NamSinh = Convert.ToInt32(getValueInput("năm sinh cần sửa: "));
                            break;
                        case "5":
                            _lstDanhBas[i].GioiTinh = Convert.ToInt32(getValueInput("giới tính cần sửa: "));
                            break;
                        case "6":
                            _lstDanhBas[i].Sdt1 = getValueInput("Sđt_1 cần sửa: ");
                            break;
                        case "7":
                            _lstDanhBas[i].Sdt2 = getValueInput("Sđt_2 cần sửa: ");
                            break;
                        case "8":
                            _lstDanhBas[i].Email = getValueInput("email cần sửa: ");
                            break;
                        case "9":
                            _lstDanhBas[i].GhiChu = getValueInput("ghi chú cần sửa: ");
                            break;
                        case "0":
                            Console.WriteLine("THANK YOU ...");
                            break;
                        default:
                            Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                            goto E;
                    }
                    Console.WriteLine("==> Sửa thành công !");
                }
            }
        }
        public void removeDanhBa()
        {
            int temp = getIndexDanhBa(getValueInput("id cần xóa: "));
            if (temp == -1)
            {
                Console.WriteLine("Mã id không tồn tại !");
                return;
            }
            _lstDanhBas.RemoveAt(temp);
            Console.WriteLine("==> Xóa thành công !");
        }
        public void sortXuoi()
        {
            _newDanhBas = _lstDanhBas.OrderBy(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = _newDanhBas;
            Console.WriteLine("==> Sắp xếp thành công !");
        }
        public void sortNguoc()
        {
            _newDanhBas = _lstDanhBas.OrderByDescending(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = _newDanhBas;
            Console.WriteLine("==> Sắp xếp thành công !");
        }
        public void getListDanhBa()
        {
            Console.WriteLine("Danh sách :");
            foreach (var x in _lstDanhBas)
            {
                x.inRaManHinh();
            }
        }
        #endregion

        #region Case 2: Lọc danh bạ (theo: tên, Sđt, giới tính, bảng chữ cái)
        public void LocTen()
        {
        T:
            _input = getValueInput("tên cần lọc: ");
            bool flag = true;
            foreach (var x in _lstDanhBas.Where(c => c.Ten == _input))
            {
                x.inRaManHinh();
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Tên cần lọc không có trong danh sách, Vui lòng nhập lại !");
                goto T;
            }
        }
        public void LocSdt()
        {
        L:
            _input = getValueInput("Sđt cần lọc: ");
            bool flag = true;
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1 == _input))
            {
                x.inRaManHinh();
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Tên cần lọc không có trong danh sách, Vui lòng nhập lại !");
                goto L;
            }
        }
        public void LocGioiTinh()
        {
        G:
            _input = getValueInput("giới tính cần lọc (1: Nam || 2: Nữ): ");
            bool flag = true;
            foreach (var x in _lstDanhBas.Where(c => c.GioiTinh == Convert.ToInt32(_input)))
            {
                x.inRaManHinh();
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("Tên cần lọc không có trong danh sách, Vui lòng nhập lại !");
                goto G;
            }
        }
        public void LocBangChuCai()
        { }
        public void LocNhaMang()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("1. Nhà mạng Viettel");
            Console.WriteLine("2. Nhà mạng Vinaphone");
            int a = Convert.ToInt32(getValueInput("lựa chọn: "));
            if (a == 1)
            {
                foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith("098") || c.Sdt2.StartsWith("098")))
                {
                    x.inRaManHinh();
                }
            }
            else if (a == 2)
            {
                foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith("036") || c.Sdt2.StartsWith("036")))
                {
                    x.inRaManHinh();
                }
            }
        }
        public void LocNhaMang1()
        {
            bool flag = true;
            string[] nhamang = new string[] { };
            O:
            Console.WriteLine("-------------------------------------------------------------------------");
            int q = Convert.ToInt32(getValueInput("lựa chọn (1-viettel, 2-Mobi, 3-Vina) :"));
            nhamang = q == 1 ? Viettel : q == 2 ? Mobi : q == 3 ? Vina : ABCD;
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                for (int j = 0; j < nhamang.Length; j++)
                {
                    if (_lstDanhBas[i].Sdt1.Substring(0, 3) == nhamang[j])
                    {
                        _lstDanhBas[i].inRaManHinh();
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Nhà mạng cần lọc không có trong danh sách, Vui lòng nhập lại !");
                goto O;
            }
        }
        #endregion

        #region Case 3: Tìm kiếm (Tìm kiếm theo tên và số điện thoại gần đúng sử dụng LINQ)
        public void findTengandung()
        {
            _input = getValueInput("tên gợi ý cần tìm kiếm: ");
            foreach (var x in _lstDanhBas.Where(c => c.Ten.StartsWith(_input)))
            {
                Console.WriteLine("----------------------");
                x.inRaManHinh();
            }
        }
        public void findSDTgandung()
        {
            _input = getValueInput("Sđt gợi ý cần tìm: ");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.ToString().StartsWith(_input) || c.Sdt2.ToString().StartsWith(_input)))
            {
                Console.WriteLine("----------------------");
                x.inRaManHinh();
            }
        }
        #endregion

        #region Case 4: Lưu trữ danh bạ (Mở file load data, Lưu File save data)
        public void GhiFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, _lstDanhBas); 
                _fs.Close();        
                System.Console.WriteLine("==> Ghi thành công");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Lưu thất bại.");
        }
        public void DocFile()
        {
            try
            {
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs); 
                _lstDanhBas = new List<DanhBa>(); 
                _lstDanhBas = (List<DanhBa>)data; 
                _fs.Close();
                Console.WriteLine("==> Đọc file thành công.");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("==> Đọc file thất bại.");
        }
        #endregion

        #region Case 0: Thoát có cảnh báo.
        public void KiemTra()
        {
            K:
            Console.WriteLine("Cảnh báo: Lưu thay đổi | Lưu dữ liệu:");
            int n = Convert.ToInt32(getValueInput("(1 - Yes / 2 - No): "));
            switch (n)
            {
                case 1:
                    GhiFile();
                    Console.WriteLine("==> Lưu thành công");
                    Environment.Exit(0);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bạn chọn sai chức năg, Vui lòng nhập lại !");
                    goto K;
            }
        }
        #endregion

    }
}
