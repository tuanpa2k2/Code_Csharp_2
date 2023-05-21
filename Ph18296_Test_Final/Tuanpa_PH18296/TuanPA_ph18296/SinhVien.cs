using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuanPA_ph18296
{
    [Serializable]
    class SinhVien
    {
        private int masv;
        private string tensv;
        private int namSinh;
        private double diemC;
        private int gioiTinh;
        public SinhVien()
        {

        }
        public SinhVien(int masv, string tensv, int namSinh, double diemC, int gioiTinh)
        {
            this.Masv = masv;
            this.Tensv = tensv;
            this.NamSinh = namSinh;
            this.DiemC = diemC;
            this.GioiTinh = gioiTinh;
        }

        public int Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemC { get => diemC; set => diemC = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public void InRaManHinh()
        {
            Console.WriteLine(" Mã SV: {0}\t | Tên SV: {1}\t | Năm sinh: {2}\t | Điểm C#: {3}\t | GiớI tính: {4}\t | Tuổi: {5} ",
                Masv, Tensv, NamSinh, DiemC, GioiTinh == 1 ? "Nam" : "Nữ", DateTime.Now.Year - Convert.ToInt32(namSinh));
        }
    }
}
