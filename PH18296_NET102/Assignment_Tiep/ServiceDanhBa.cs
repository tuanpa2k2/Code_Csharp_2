using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace Assignment
{
    class ServiceDanhBa
    {
        private List<DanhBa> _lstDanhBas = new List<DanhBa>();
        private List<DanhBa> newlist = new List<DanhBa>();
        private DanhBa _danhBa;
        private string _input;
        private int _numb;
        static bool numbercheck;
        private FileStream _fs;
        private BinaryFormatter _bf;
        private static int _numsave;
        static string path = @"D:\FPL\Summer 2021\NET102\Assignment\Assignment\zxc.bin";
        private string[] Viettel = new string[]{"086", "096", "097", "098", "032", "033", "034", "035", "036", "037", "038", "039"};
        private string[] Vina = new string[] { "091", "094", "083", "084", "085", "081", "082", "088" };
        private string[] Mobi = new string[] { "089", "090", "093", "070", "079", "077", "076", "078" };
        private string[] ASDF = new string[] { };

        public ServiceDanhBa()
        {
            //DanhBa st1 = new DanhBa("phi", "anh", "tuan", 2002, "Nam", "0365269311", "0000000000", "tuanpaph@gmail.com", "0");
            //DanhBa st2 = new DanhBa("phi", "anh", "an", 1997, "Nam", "0965269312", "0000000000", "anhpaph@gmail.com", "0");
            //DanhBa st3 = new DanhBa("phi", "anh", "em", 2001, "Nam", "0355269313", "0000000000", "empaph@gmail.com", "0");
            //DanhBa st4 = new DanhBa("ngo", "dinh", "tiep", 2001, "Nam", "0865953212", "0000000000", "tiepndph@gmail.com", "0");
            //DanhBa st5 = new DanhBa("ngo", "trac", "viet", 2005, "Nam", "0395269312", "0000000000", "anhndph@gmail.com", "0");
            //DanhBa st6 = new DanhBa("ngo", "dinh", "van", 2003, "Nam", "0915269313 ", "0000000000", "empand@gmail.com", "0");
            //DanhBa st7 = new DanhBa("bui", "tuan", "anh", 1999, "Nam", "0839839506", "0000000000", "anhbtph@gmail.com", "0");
            //DanhBa st8 = new DanhBa("bui", "tuan", "dinh", 2001, "Nữ", "0855269312", "0000000000", "embtph@gmail.com", "0");
            //DanhBa st9 = new DanhBa("tran", "thi", "thao", 2005, "Nữ", "0885872186", "0000000000", "thaottph@gmail.com", "0");
            //DanhBa st10 = new DanhBa("phi", "thao", "nguyen", 2007, "Nữ", "0944721835", "0000000000", "vanptph@gmail.com", "0");
            //DanhBa st11 = new DanhBa("pham", "trang", "nhung", 1998, "Nữ", "0895269311", "0000000000", "nhungptph@gmail.com", "0");
            //DanhBa st12 = new DanhBa("nguyen", "thu", "trang", 2002, "Nữ", "0903792216", "0000000000", "thuyntph@gmail.com", "0");
            //DanhBa st13 = new DanhBa("nguyen", "thanh", "thuy", 2002, "Nữ", "0773905080", "0986038923", "thuynt1ph@gmail.com", "0");
            //DanhBa st14 = new DanhBa("nguyen", "anh", "dao", 2002, "Nữ", "0795496705", "0000000000", "daonaph@gmail.com", "0");
            //DanhBa st15 = new DanhBa("phi", "van", "an", 1996, "Nam", "0787723375", "0000000000", "danpvph@gmail.com", "0");
            //_lstDanhBas.Add(st1);
            //_lstDanhBas.Add(st2);
            //_lstDanhBas.Add(st3);
            //_lstDanhBas.Add(st4);
            //_lstDanhBas.Add(st5);
            //_lstDanhBas.Add(st6);
            //_lstDanhBas.Add(st7);
            //_lstDanhBas.Add(st8);
            //_lstDanhBas.Add(st9);
            //_lstDanhBas.Add(st10);
            //_lstDanhBas.Add(st11);
            //_lstDanhBas.Add(st12);
            //_lstDanhBas.Add(st13);
            //_lstDanhBas.Add(st14);
            //_lstDanhBas.Add(st15);
        }
        public void xuatDanhSach()
        {
            inds(_lstDanhBas);
        }
        private string getInputValue(string mess)
        {
            string vals;

            do
            {
                Console.Write("Mời bạn nhập " + mess);
                vals = Console.ReadLine();
                numbercheck = false;
                try
                {
                    Check(vals);
                }
                catch (Exception)
                { }
            } while (numbercheck);
            return vals;
        }
        static void Check(string ten)
        {
            if (string.IsNullOrEmpty(ten))
            {
                numbercheck = true;
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.Write("(vui lòng nhập dữ liệu.)");
            }
        }
        static int getvalues(string name)
        {
            int r = 0;
            try
            {
                r = Convert.ToInt32(name);
            }
            catch (Exception)
            { }
            return r;
        }
        static char getchu(string name)
        {
            char r = 'a';
            try
            {
                r = Convert.ToChar(name);
            }
            catch (Exception)
            { }
            return r;
        }

        void inds(List<DanhBa> lstStudents)
        {
            int STT = 1;
            foreach (var x in lstStudents)
            {
                Console.WriteLine("\n*{0}*", STT);
                x.inRaManHinh();
                STT++;
            }
        }
        public void themNguoi()
        {
            _numb = getvalues(getInputValue("số lượng cần thêm: "));
            for (int i = 0; i < _numb; i++)
            {
                _danhBa = new DanhBa();
                Console.WriteLine("----------*{0}*-------------------------------------------------", i + 1);
                _danhBa.Ho = getInputValue("họ: ");
                _danhBa.TenDem = getInputValue("tên đệm: ");
                _danhBa.Ten = getInputValue("tên: ");
                _danhBa.NamSinh = getvalues(getInputValue("năm sinh: "));
                _danhBa.GioiTinh = getInputValue("giới tính: ");
                _danhBa.Sdt1 = getInputValue("SĐT_1: ");
                _danhBa.Sdt2 = getInputValue("SĐT_2: ");
                _danhBa.Email = getInputValue("email: ");
                _danhBa.GhiChu = getInputValue("ghi chú: ");
                _lstDanhBas.Add(_danhBa);
                _numsave++;
            }
        }
        public void suaNguoi()
        {
            _input = getInputValue("tên cần sửa: ");
            int temp = getIndexNguoi(_input);
            if (temp == -1)
            {
                Console.WriteLine("Tên không tồn tại trong danh bạ.");
                return;
            }
            Console.WriteLine(" 1. Họ : " + _lstDanhBas[temp].Ho);
            Console.WriteLine(" 2. Tên đệm : " + _lstDanhBas[temp].TenDem);
            Console.WriteLine(" 3. Tên :" + _lstDanhBas[temp].Ten);
            Console.WriteLine(" 4. Năm sinh :" + _lstDanhBas[temp].NamSinh);
            Console.WriteLine(" 5. Giới tính :" + _lstDanhBas[temp].GioiTinh);
            Console.WriteLine(" 6. SĐT_1 :" + _lstDanhBas[temp].Sdt1);
            Console.WriteLine(" 7. SĐT_2 :" + _lstDanhBas[temp].Sdt2);
            Console.WriteLine(" 8. Email :" + _lstDanhBas[temp].Email);
            Console.WriteLine(" 9. Ghi chú :" + _lstDanhBas[temp].GhiChu);
            Console.WriteLine(" 10. Exit ...");
            _input = getInputValue("phần muốn sửa");
            switch (_input)
            {
                case "1":
                    _lstDanhBas[temp].Ho = getInputValue("họ cần thay đổi: ");
                    break;
                case "2":
                    _lstDanhBas[temp].TenDem = getInputValue("tên đệm cần thay đổi: ");
                    break;
                case "3":
                    _lstDanhBas[temp].Ten = getInputValue("họ cần thay đổi: ");
                    break;
                case "4":
                    _lstDanhBas[temp].NamSinh = getvalues(getInputValue("nhập năm sinh cần thay đổi: "));
                    break;
                case "5":
                    _lstDanhBas[temp].GioiTinh = getInputValue("giới tính cần thay đổi: ");
                    break;
                case "6":
                    _lstDanhBas[temp].Sdt1 = getInputValue("sđt_1 cần thay đổi: ");
                    break;
                case "7":
                    _lstDanhBas[temp].Sdt2 = getInputValue("sđt_2 cần thay đổi: ");
                    break;
                case "8":
                    _lstDanhBas[temp].Email = getInputValue("email cần thay đổi: ");
                    break;
                case "9":
                    _lstDanhBas[temp].GhiChu = getInputValue("ghi chú cần thay đổi: ");
                    break;
                case "10":
                    Console.WriteLine("___Thanks You___");
                    break;
                default:
                    Console.WriteLine("Bạn nhập sai chức năng của bài, Vui lòng nhập lại.");
                    Console.ReadKey();
                    break;
            }
            _numsave++;
            Console.WriteLine("Sửa thành công");
        }
        public void xoaNguoi()
        {
            int temp = getIndexNguoi(getInputValue("tên cần xóa khỏi danh bạ:"));
            if (temp == -1)
            {
                Console.WriteLine("Tên cần xóa không có trong danh bạ.");
                return;
            }
            _lstDanhBas[temp].inRaManHinh();
            _lstDanhBas.RemoveAt(temp);
            _numsave++;
            Console.WriteLine("--- Bạn đã xóa thành công !");
        }
        public int getIndexNguoi(string ten)
        {
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                if (_lstDanhBas[i].Ten == ten)
                {
                    return i;
                }
            }
            return -1;
        }
        public void TimSDTgandung()
        {
            int ttsdtgd = 1;
            string sdt = getInputValue("số gợi ý :");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith(sdt) || c.Sdt2.StartsWith(sdt)))
            {
                Console.WriteLine("====={0}=====", ttsdtgd);
                x.inRaManHinh();
                ttsdtgd++;
            }
            if (ttsdtgd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void TimTengandung()
        {
            int tttengd = 1;
            string tengy = getInputValue("tên gợi ý :");
            foreach (var m in _lstDanhBas.Where(c => c.Ten.StartsWith(tengy)))
            {
                Console.WriteLine("====={0}=====", tttengd);
                m.inRaManHinh();
                tttengd++;
            }
            if (tttengd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void sapxepxuoi()
        {
            newlist = _lstDanhBas.OrderBy(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = newlist;
            _numsave++;
        }
        public void sapxepnguoc()
        {
            newlist = _lstDanhBas.OrderByDescending(c => c.Ten).ToList();
            _lstDanhBas.Clear();
            _lstDanhBas = newlist;
            _numsave++;
        }
        public void loctheoabc()
        {
            int ttsdtgd = 1;
            char chucai = getchu(getInputValue(" "));
            string chucai1 = Convert.ToString(chucai);
            foreach (var x in _lstDanhBas.Where(c => c.Ten.StartsWith(chucai1)))
            {
                Console.WriteLine("====={0}=====", ttsdtgd);
                x.inRaManHinh();
                ttsdtgd++;
            }
            if (ttsdtgd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void loctheogioitinh()
        {
            int ttsdtgd = 1;
            int gt = getvalues(getInputValue(" (1-Nam,2-Nữ) :"));
            string chucai = gt == 1 ? "Nam" : gt == 2 ? "Nữ" : "vbnm";
            foreach (var x in _lstDanhBas)
            {
                if (x.GioiTinh==chucai)
                {
                    Console.WriteLine("====={0}=====", ttsdtgd);
                    x.inRaManHinh();
                    ttsdtgd++;
                }
            }
            if (ttsdtgd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void loctheoten()
        {
            int ttsdtgd = 1;
            string chucai = getInputValue(" ");
            foreach (var x in _lstDanhBas.Where(c => c.Sdt1.StartsWith(chucai)))
            {
                Console.WriteLine("====={0}=====", ttsdtgd);
                x.inRaManHinh();
                ttsdtgd++;
            }
            if (ttsdtgd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void locnhamang()
        {
            int ttsdtgd = 1;
            string[] nhamang = new string[] { };
            int gt = getvalues(getInputValue(" (1-viettel, 2-Mobi, 3-Vina) :"));
            nhamang = gt == 1 ? Viettel : gt == 2 ? Mobi: gt == 3 ? Vina : ASDF;
            for (int i = 0; i < _lstDanhBas.Count; i++)
            {
                for (int j = 0; j < nhamang.Length; j++)
                {
                    if (_lstDanhBas[i].Sdt1.Substring(0,3) == nhamang[j])
                    {
                        Console.WriteLine("====={0}=====", ttsdtgd);
                        _lstDanhBas[i].inRaManHinh();
                        ttsdtgd++;
                    }
                }
            }
            if (ttsdtgd == 1)
            {
                Console.WriteLine("Không tìm thấy");
            }
        }
        public void DocFile()
        {
            DocFile1(path);
        }
        public void DocFile1(string path)
        {
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);
            _lstDanhBas = new List<DanhBa>();
            _lstDanhBas = (List<DanhBa>)data;
            _fs.Close();
        }
        public void GhiFile()
        {
            GhiFile1(path);
            _numsave = 0;
        }
        public void GhiFile1(string path)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, _lstDanhBas);
            _fs.Close();
        }
        public void KiemTra()
        {
            if (_numsave==0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Lưu thay đổi. Lưu dữ liệu :");
                int n = getvalues(getInputValue("(1 - Yes / 2 - No) :"));
                while (true)
                {
                    switch (n)
                    {
                        case 1:
                            GhiFile();
                            Console.WriteLine("Lưu thành công");
                            Environment.Exit(0);
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine(" phại lại");
                            break;
                    }
                }
            }
        }
    }
}