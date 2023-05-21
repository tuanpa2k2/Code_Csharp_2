using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._1_ONTAP_CSHARP_CURD_NANGCAO
{
    //Lớp cha: Đưa các thuộc tính chung và phương thức chung lên lớp cha
    //Lớp cha abstract: giống như lớp cha bình thường chỉ khác là phải có phương thức abstract trong class
    abstract class Person
    {
        private int id;
        private string name;
        private string phone;
        private int sex;

        public Person()
        {

        }
        public Person(int id, string name, string phone, int sex)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.sex = sex;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Sex { get => sex; set => sex = value; }
        public virtual void inRaManHinh1()
        {

        }

        //Phương thức abstract: không có body code
        public abstract void inRaManHinh2();
        public abstract void inRaManHinh3();
        public abstract void inRaManHinh4(string year, string school);
    }
}
