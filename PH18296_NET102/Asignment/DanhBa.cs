using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    [Serializable]
    class DanhBa : Nguoi
    {
        private string sdt1;
        private string sdt2;
        private string email;
        private string ghiChu;
        public DanhBa()
        {

        }

        public DanhBa(int id, string ho, string tenDem, string ten, int namSinh, int gioiTinh, string sdt1, string sdt2, string email, string ghiChu) :
            base(id, ho, tenDem, ten, namSinh, gioiTinh)
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
            Console.WriteLine(" Id: {0}\t | Họ và tên:\t {1}\n\t | Năm sinh:\t {2}\n\t | Giới tính:\t {3}\n\t | Sđt_1:\t {4}\n\t | Sđt_2:\t {5}\n\t | Email:\t {6}\n\t | Ghi chú:\t {7}\n",
                Id, (Ho + " " + TenDem + " " + Ten), NamSinh, GioiTinh == 1 ? "Nam" : "Nữ", Sdt1, Sdt2, Email, GhiChu);
        }
    }
}