using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP_CURD_NANGCAO
{
    class Student:Person
    {
        private string msv;
        private string gpa;

        public Student()
        {

        }

        public Student(int id, string name, string phone, int sex, string msv, string gpa) : base(id, name, phone, sex)
        {
            this.msv = msv;
            this.gpa = gpa;
        }

        public string Msv { get => msv; set => msv = value; }
        public string Gpa { get => gpa; set => gpa = value; }

        public override void inRaManHinh2()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh3()
        {
            throw new NotImplementedException();
        }

        public override void inRaManHinh4(string year, string school)
        {
            throw new NotImplementedException();
        }
    }
}
