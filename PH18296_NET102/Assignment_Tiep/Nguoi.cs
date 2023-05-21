using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment
{
    [Serializable]
    class Nguoi
    {
        private string ho;
        private string tenDem;
        private string ten;
        private int namSinh;
        private string gioiTinh;

        public Nguoi()
        {

        }

        public Nguoi(string ho, string tenDem, string ten, int namSinh, string gioiTinh)
        {
            this.Ho = ho;
            this.TenDem = tenDem;
            this.Ten = ten;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
        }

        public string Ho { get => ho; set => ho = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public virtual void inRaManHinh()
        {
            Console.WriteLine(" Họ: {0}\n  Tên: {1}\n  Tên đệm: {2}\n  Năm sinh: {3}\n  Giới tính: {4}", Ho, Ten, TenDem, NamSinh, GioiTinh);
        }
    }
}
