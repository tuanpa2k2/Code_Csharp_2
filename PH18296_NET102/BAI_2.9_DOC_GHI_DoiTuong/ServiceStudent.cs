using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._9_DOC_GHI_DoiTuong
{
    class ServiceStudent
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        private List<Student> _lstStudents;
        public ServiceStudent()
        {
            _lstStudents = new List<Student>();
        }
        //Ghi vào file dữ liệu gì và lưu ở đâu
        public void GhiFile(List<Student> lstStudent, string path)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();        //Khởi tạo
            _bf.Serialize(_fs, lstStudent);     //Serialize Tuần tự hóa hoặc tuần tự hóa là quá trình dịch cấu trúc dữ liệu hoặc
                                                    //  trạng thái đối tượng sang định dạng có thể được lưu trữ hoặc truyền và tái tạo lại sau này.
            _fs.Close();
        }

        public void DocFile(string path)
        {
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();//Khởi tạo
            var data = _bf.Deserialize(_fs);//Đọc đối tượng lên
            _lstStudents = new List<Student>();
            _lstStudents = (List<Student>)data;//Gán lại List object cho List Student
            _fs.Close();
        }

        public List<Student> GetStudents()
        {
            return _lstStudents;
        }
    }
}

