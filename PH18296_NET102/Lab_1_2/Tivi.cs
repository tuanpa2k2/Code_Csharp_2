using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    class Tivi
    {
        private int id;
        private string maTv;
        private string ten;
        private string loai;

        public Tivi()
        {

        }
        public Tivi(int id, string maTv, string ten, string loại)
        {
            this.Id = id;
            this.MaTv = maTv;
            this.Ten = ten;
            this.Loại = loại;
        }

        public int Id { get => id; set => id = value; }
        public string MaTv { get => maTv; set => maTv = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Loại { get => loai; set => loai = value; }
        public void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Mã Tivi: {1}\n Tên Tivi: {2}\n Loại Tivi: {3}\n ", id, maTv, ten, loai );
        }
    }
}
