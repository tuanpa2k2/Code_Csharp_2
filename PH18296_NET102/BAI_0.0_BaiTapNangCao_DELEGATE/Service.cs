using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_0._0_BaiTapNangCao_DELEGATE
{
    class Service
    {
        /*
        Bài tập 1 về delegate:
            Viết 1 chương trình sử dụng event delegate với đầu bài như sau. Viết 1 chương trình cho phép người dùng nhập vào 
            các thông tin về lập trình viên bao gồm các thuộc tính sau(Tên, Số điện thoại, Năm kinh nghiệm). 
            Cho lập trình viên nhập thông tin vào sau đó chạy lặp lại thông tin nhập năm kinh nghiệm cho lập trình viên đó và 
            phát đi sự kiện theo các điều kiện sau:
                - 0 năm kinh nghiệm Fresher
                - Từ 1 năm đến 3 năm là Junior
                - Từ 4 năm đến 10 năm là Senior
            Ví dụ: 
            Nhập các thông tin Tên số điện thoại thì tương tự như bài tập bình thường nhưng đối với Event sẽ theo dõi số năm thay 
            đổi liên tục của năm kinh nghiệm do lập trình viên đó và phát ra thông báo như điều kiện sau.
            ==> Gợi ý: Sử dụng lặp chỗ năm kinh nghiệm
        Bài tập 2: Mức cơ bản về Delegate
            - Xây dựng 1 Chương trình máy tính đơn giản có sử dụng Switch Case bao gồm các chứng năng CỘNG - TRỪ - NHÂN - CHIA 
                với 2 số và 1 chức năng cuối số 5 là THỰC HIỆN HẾT 4 PHÉP TOÁN TRÊN.
            - Gợi ý: Đối với các phép toán sử dụng Delegate để thực thi và đối với chức năng cuối các bạn += 4 phương thức vào 1 Delegate để gọi.
        Các bạn nào đang yếu vui lòng làm thử bài này khá là cơ bản, Và sẽ hiểu hơn về delegate
        */

        private List<LapTrinhVien> _lstLapTrinhs = new List<LapTrinhVien>();
        private LapTrinhVien _lapTrinhVien;
        public Service()
        {

        }
        
        public void eventDelegate()
        {
            _lapTrinhVien = new LapTrinhVien();
            Console.Write("Mời bạn nhập tên: ");
            _lapTrinhVien.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập số điện thoại: ");
            _lapTrinhVien.Sdt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập năm kinh nghiệm: ");
            _lapTrinhVien.Namkn = Convert.ToInt32(Console.ReadLine());

            _lstLapTrinhs.Add(_lapTrinhVien);
        }
        public void getListLapTrinhVien()
        {
            foreach (var x in _lstLapTrinhs)
            {
                if (x.Namkn >=0 && x.Namkn <1)
                {
                    Console.WriteLine("-------------------------------------------");
                    x.inRaManHinh();
                    Console.WriteLine("==> Bạn đang là Fresher năm kn");
                }
                else if (x.Namkn >= 1 && x.Namkn <=3)
                {
                    Console.WriteLine("-------------------------------------------");
                    x.inRaManHinh();
                    Console.WriteLine("==> Bạn đang là Junior " + _lstLapTrinhs.Count + " năm kn");
                }
                else if (x.Namkn >3  && x.Namkn <= 10)
                {
                    Console.WriteLine("-------------------------------------------");
                    x.inRaManHinh();
                    Console.WriteLine("==> Bạn đang là Senior");
                }
            }
        }
    }
}
