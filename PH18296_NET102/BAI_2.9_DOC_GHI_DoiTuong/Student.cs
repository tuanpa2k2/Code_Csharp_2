using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._9_DOC_GHI_DoiTuong
{
    [Serializable]
    class Student
    {
        private int id;
        private string msv;
        private string name;
        public Student()
        {

        }
        public Student(int id, string msv, string name)
        {
            this.Id = id;
            this.Msv = msv;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Msv { get => msv; set => msv = value; }
        public string Name { get => name; set => name = value; }
        public void inRaManHinh()
        {
            //C1:
            Console.WriteLine(" Id: {0}\n Mã sinh viên: {1}\n Tên: {2}", Id, Msv, Name);
            //C2:
            //Console.WriteLine($" {Id} + {Msv} + {Name}");
        }
    }
}
