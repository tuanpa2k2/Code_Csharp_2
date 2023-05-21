using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._2_CLASS_GENNERIC
{
    class PolyGeneric<T>
    {
        private T[] arrs; //Mảng chưa xác định kiểu
        public PolyGeneric(int size)
        {
            Arrs = new T[size];
        }
        public T[] Arrs 
        { 
            get => arrs; 
            set => arrs = value; 
        }
        //Phương thức trả về lấy giá trị của mảng !
        public T getValueByIndex(int index)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return arrs[index];
        }
        //Gán giá trị vào mảng !
        public void addValueByIndex(int index, T value)
        {
            if (index < 0 || index >= arrs.Length)
            {
                throw new IndexOutOfRangeException();
            }
            arrs[index] = value;
        }
    }
}
