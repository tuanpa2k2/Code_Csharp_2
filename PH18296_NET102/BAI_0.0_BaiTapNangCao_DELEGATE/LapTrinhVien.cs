using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_0._0_BaiTapNangCao_DELEGATE
{
    delegate void ShowNamKinhNghiem(int namKinhNghiemID);
    class LapTrinhVien
    {
        public event ShowNamKinhNghiem NamKinhNghiemChanged;
        private string ten;
        private int sdt;
        private int namkn;
        public LapTrinhVien()
        {

        }
        public LapTrinhVien(string ten, int sdt, int namkn)
        {
            this.Ten = ten;
            this.Sdt = sdt;
            this.Namkn = namkn;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public int Namkn 
        { 
            get => namkn; 
            set
            {
                namkn = value;
                if (NamKinhNghiemChanged != null)
                {
                    NamKinhNghiemChanged(namkn);
                }
            } 
        }
        public void inRaManHinh()
        {
            Console.WriteLine(" Tên: {0}\n Sđt: {1}\n Năm kinh nghiệm: {2}", ten, sdt, namkn);
        }
    }
}
