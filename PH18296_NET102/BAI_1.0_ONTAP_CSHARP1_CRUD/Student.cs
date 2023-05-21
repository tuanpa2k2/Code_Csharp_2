using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class Student
    {
        //Phần 1: liệt kê tất cả các thuộc tính mà đối tượng phải có
        private int id;
        private string name;
        private int gioiTinh;

        //Phần 2: Khởi tạo 2 contructer
        //1. Contructer k tham số: ctor + tab
        public Student()
        {

        }
        //2. Contructer có tham số 
        public Student(int id, string name, int gioiTinh)
        {
            this.Id = id;
            this.Name = name;
            this.GioiTinh = gioiTinh;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public void inRaManHinh()
        {
            Console.WriteLine(" Id: {0}\n Name: {1}\n Giới Tính: {2}", id, name, gioiTinh == 1 ? "Nam\n" : "Nữ\n");
        }
    }
}
