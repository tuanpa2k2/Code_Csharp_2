using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment
{
    [Serializable]
    class DanhBa:Nguoi
    {
        private string sdt1;
        private string sdt2;
        private string email;
        private string ghiChu;

        public DanhBa()
        {

        }

        public DanhBa(string ho, string tenDem, string ten, int namSinh, string gioiTinh, string sdt1, string sdt2, string email, string ghiChu) : base(ho, tenDem, ten, namSinh, gioiTinh)
        {
            this.Sdt1 = sdt1;
            this.Sdt2 = sdt2;
            this.Email = email;
            this.GhiChu = ghiChu;
        }

        public string Sdt1 { get => sdt1; set => sdt1 = value; }
        public string Sdt2 { get => sdt2; set => sdt2 = value; }
        public string Email { get => email; set => email = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public override void inRaManHinh()
        {
            Console.WriteLine("{0}\0{1}\0{2}\nNăm sinh: {3}\nGiới tính: {4}\nSĐT_1: {5}\nSĐT_2: {6}\nEmail: {7}\nGhi chú: {8}",
                Ho, TenDem, Ten, NamSinh, GioiTinh, sdt1, sdt2, email, ghiChu);
        }
    }
}
