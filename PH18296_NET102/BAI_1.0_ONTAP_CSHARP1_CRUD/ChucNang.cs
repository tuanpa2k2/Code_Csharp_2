using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAI_1._0_ONTAP_CSHARP1_CRUD
{
    class ChucNang
    {
        private List<Student> _lstStudents = new List<Student>();
        private Student _student;
        private string _input;

        public ChucNang()
        {
            //_lstStudents = new List<Student>();
            //Tạo 3 đối tượng sinh viên ảo có sẵn
            _student = new Student(0, "A1", 0);
            _lstStudents.Add(_student);
            _student = new Student(1, "A2", 1);
            _lstStudents.Add(_student);
            _student = new Student(2, "A3", 0);
            _lstStudents.Add(_student);

        }

        //Phương thức "getInputValue" là phương thức trả về giá trị của người dùng nhập vào
        private string getInputValue(string mess)
        {
            Console.Write("Mời bạn nhập " + mess);
            return Console.ReadLine();
        }
        //Phương thức lấy ra index của đối tượng trong danh sách phục vụ cho tìm kiếm và xóa 
        private int getIndexStudent(string idStudent)
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Id == Convert.ToInt32(idStudent))
                {
                    return i;  //Khi tìm thấy thì sẽ trả về index của đối tượng
                }
            }
            return -1;  //Khi không tìm thấy sẽ trả ra giá trị -1
        }
        public bool addStudentRutGon()
        {
            do
            {
                _input = getInputValue("số lượng sinh viên: ");
                for (int i = 0; i < Convert.ToInt32(_input); i++)
                {
                    _student = new Student();            // khởi tạo mới đối tượng để sử dụng
                    _student.Id = _lstStudents.Count;    // _lstStudents.Count : lấy ra kích thước của list đối tượng và kích thước chhính là vị trí tiếp theo trong Index
                    _student.Name = getInputValue("tên: ");
                    _student.GioiTinh = Convert.ToInt32(getInputValue("giới tính (1: Nam || 0: Nữ): "));
                    //.Id: nghĩa là chỉ đến property
                    _lstStudents.Add(_student);          // thêm 1 đối tượng vào list sau mỗi lần nhập thông tin
                }
                Console.Write("==> Bạn có muốn nhập tiếp k ? y/n : ");
                _input = Console.ReadLine();

            } while (!(_input.ToLower() == "n"));
            return true;
        }
        //In danh sách sinh viên
        public void getListStudent()
        {
            Console.WriteLine("Danh sách sinh viên: ");
            foreach (var x in _lstStudents)
            {
                x.inRaManHinh();
            }
        }
        public void findStudent()
        {
            //C1: thông thường 
            _input = getInputValue("Id: ");
            ///C1.1: Dùng Flag để kiểm tra và thông báo sinh viên không tồn tại
            ///C1.2: Dùng return;
            //bool flag = true;
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Id == Convert.ToInt32(_input))
                {
                    Console.WriteLine("Sinh viên cần tìm là: ");
                    _lstStudents[i].inRaManHinh();
                    Console.WriteLine("---------------------------------");
                    return;
                    //flag = false;
                }
            }
            //if (flag)
            //{
            //    Console.WriteLine("Mã ID sinh viên k tồn tại !");
            //}
            Console.WriteLine("Mã ID sinh viên k tồn tại !");
        }
        public void findStudentNangCao()
        {
            int temp = getIndexStudent(getInputValue("mã Id cần tìm: "));
            if (temp == -1)
            {
                Console.WriteLine("==> Mã Id sinh viên không tồn tại !");
                return;
            }
            _lstStudents[temp].inRaManHinh();
        }
        public void removeStudentNangCao()
        {
            int temp = getIndexStudent(getInputValue("mã Id cần xóa: "));
            if (temp == -1)
            {
                Console.WriteLine("==> Mã Id sinh viên không tồn tại !");
                return;
            }
            _lstStudents.RemoveAt(temp);
            Console.WriteLine("==> Bạn đã xóa thành công !");
        }
    }
}
