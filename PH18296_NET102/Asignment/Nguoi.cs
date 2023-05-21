using System;

namespace Asignment
{
    [Serializable]
    partial class Nguoi
    {
        private int id;
        private string ho;
        private string tenDem;
        private string ten;
        private int namSinh;
        private int gioiTinh;
        public Nguoi()
        {

        }

        public Nguoi(int id, string ho, string tenDem, string ten, int namSinh, int gioiTinh)
        {
            this.Id = id;
            this.Ho = ho;
            this.TenDem = tenDem;
            this.Ten = ten;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
        }

        
        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Họ: {1}\n Tên đệm: {2}\n Tên: {3}\n Năm sinh: {4}\n Giới tính: {5} ",
                Id, Ho, TenDem, Ten, NamSinh, GioiTinh == 1 ? "Nam\n" : "Nữ\n");
        }
    }
}
