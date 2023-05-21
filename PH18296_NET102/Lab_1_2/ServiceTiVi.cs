using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_1_2
{
    class ServiceTiVi
    {
        private List<Tivi> _lstTivis = new List<Tivi>();
        private Tivi _tiVi;
        private string _input;

        public ServiceTiVi()
        {
            _tiVi = new Tivi( 0, "t1", "Samsung", "32i");
            _lstTivis.Add(_tiVi);
            _tiVi = new Tivi( 1, "t2", "Soni", "32i");
            _lstTivis.Add(_tiVi);
            _tiVi = new Tivi( 2, "t3", "Eogy", "64i");
            _lstTivis.Add(_tiVi);
        }
        private string getInputValue(string mes)
        {
            Console.Write("Mời bạn nhập " + mes);
            return Console.ReadLine();
        }
        private int getIndexId(string idTV)
        {
            for (int i = 0; i < _lstTivis.Count; i++)
            {
                if (_lstTivis[i].Id == Convert.ToInt32(idTV))
                {
                    return i;  
                }
            }
            return -1;    
        }
        public void getListTivi()
        {
            Console.WriteLine("\n==> Danh sách Tivi: ");
            foreach (var x in _lstTivis)
            {
                x.inRaManHinh();
            }
        }
        // Các chức năg !
        public void addTivi()
        {
            try
            {
                do
                {
                    _input = getInputValue("số lượng Tivi cần thêm: ");
                    for (int i = 0; i < Convert.ToInt32(_input); i++)
                    {
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Thông tin TV "+ (i+1)+ ":");
                        _tiVi = new Tivi();         
                        _tiVi.Id = _lstTivis.Count; 
                        _tiVi.MaTv = getInputValue("mã Tivi: ");
                        _tiVi.Ten = getInputValue("tên Tivi: ");
                        _tiVi.Loại = getInputValue("loại tivi: ");

                        _lstTivis.Add(_tiVi);
                    }
                    Console.Write("==> Bạn có muốn nhập tiếp k ? (...y|n...): ");
                    _input = Console.ReadLine();

                } while (!(_input.ToLower() == "n"));  
            }
            catch (Exception cn1)
            {
                Console.WriteLine(" ==> Lỗi rồi ! : ");
                Console.WriteLine(cn1.Message);              
                Console.WriteLine(cn1.StackTrace);           
                Console.WriteLine(cn1.GetType().Name);       
                Console.WriteLine(cn1);
            }
        }
        public void updateTivi()
        {
            try
            {
                S:
                _input = getInputValue("Id Tivi cần sửa: ");
                for (int i = 0; i < _lstTivis.Count; i++)
                {
                    if (_lstTivis[i].Id == Convert.ToInt32(_input))
                    {
                    A:
                        Console.WriteLine("Các thông tin được phép sửa :");
                        Console.WriteLine(" 1: Mã TV");
                        Console.WriteLine(" 2: Tên TV");
                        Console.WriteLine(" 3: Loại TV");
                        _input = getInputValue("phần cần sửa: ");
                        switch (_input)
                        {
                            case "1":
                                _lstTivis[i].MaTv = getInputValue("mã thay đổi: ");
                                break;
                            case "2":
                                _lstTivis[i].Ten = getInputValue("tên thay đổi: ");
                                break;
                            case "3":
                                _lstTivis[i].Loại = getInputValue("loại thay đổi: ");
                                break;
                            default:
                                Console.WriteLine("==> Bạn chọn sai chức năng, Vui lòng nhập lại !");
                                goto A;
                        }
                        Console.WriteLine("==> Chúc mừng bạn sửa thành công !");
                        return;
                    }
                }
                Console.WriteLine("==> Mã Id TV không tồn tại, Mời bạn nhập lại !");
                goto S;
            }
            catch (Exception cn2)
            {
                Console.WriteLine(" ==> Lỗi rồi ! : ");
                Console.WriteLine(cn2.Message);
                Console.WriteLine(cn2.StackTrace);
                Console.WriteLine(cn2.GetType().Name);
                Console.WriteLine(cn2);
            }
        }
        public void removeTivi()
        {
            try
            {
                int temp = getIndexId(getInputValue("Id cần xóa: "));
                if (temp == -1)
                {
                    Console.WriteLine("==> Mã id không tồn tại !");
                    return;
                }
                _lstTivis.RemoveAt(temp);
                Console.WriteLine("Bạn đã xóa thành công !");
            }
            catch (Exception cn3)
            {
                Console.WriteLine(" ==> Lỗi rồi ! : ");
                Console.WriteLine(cn3.Message);
                Console.WriteLine(cn3.StackTrace);
                Console.WriteLine(cn3.GetType().Name);
                Console.WriteLine(cn3);
            }
        }
        public void findTivi()
        {
            try
            {
                _input = getInputValue("tên gợi ý cần tìm: ");
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("Danh sách tên Tivi gợi ý cần tìm:");
                foreach (var x in (_lstTivis.Where(c => c.Ten.StartsWith(_input))))
                {
                    x.inRaManHinh();
                }
            }
            catch (Exception cn4)
            {
                Console.WriteLine(" ==> Lỗi rồi ! : ");
                Console.WriteLine(cn4.Message);
                Console.WriteLine(cn4.StackTrace);
                Console.WriteLine(cn4.GetType().Name);
                Console.WriteLine(cn4);
            }
        }
    }
}
