using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TUANPAPH18296
{
    [Serializable]
    partial class SinhVien
    {
        private string masv;
        private string ten;
        private int namSinh;

        public SinhVien()
        {

        }

        public SinhVien(string masv, string ten, int namSinh)
        {
            this.Masv = masv;
            this.Ten = ten;
            this.NamSinh = namSinh;
        }

        
        public void inRaManHinh()
        {
            Console.WriteLine(" Mã sinh viên: {0}\t | Tên sinh viên: {1}\t | Năm sinh: {2}\t | Tuổi: {3}", Masv,Ten, NamSinh, DateTime.Now.Year - Convert.ToInt32(namSinh));
        }
    }
}
