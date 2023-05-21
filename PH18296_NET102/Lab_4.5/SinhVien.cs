using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._5
{
    [Serializable]
    class SinhVien
    {
        private int id;
        private string masv;
        private string ten;
        private int nganhHoc;
        private int trangThai;
        private bool gioiTinh;
        public SinhVien()
        {

        }

        public SinhVien(int id, string masv, string ten, int nganhHoc, int trangThai, bool gioiTinh)
        {
            this.Id = id;
            this.Masv = masv;
            this.Ten = ten;
            this.NganhHoc = nganhHoc;
            this.TrangThai = trangThai;
            this.GioiTinh = gioiTinh;
        }

        public int Id { get => id; set => id = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public void InRaManHinh()
        {
            Console.WriteLine(" Id: {0}\t | Mã sinh viên: {1}\t | Tên: {2}\t | Ngành học: {3}\t | Trạng thái: {4}\t | Giới tính: {5} ",
                Id, Masv, Ten, NganhHoc == 1 ? "UDPM" : NganhHoc == 2 ? "WEB" : "MOB"
                            , TrangThai == 1 ? "Học lại" : TrangThai == 2 ? "Học đi" : "Thôi học",
                              GioiTinh == true ? "Nam" : "Nữ");
        }
    }
}
