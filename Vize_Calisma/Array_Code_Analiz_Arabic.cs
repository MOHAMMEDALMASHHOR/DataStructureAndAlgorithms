using System.Collections;
using DataStructures.Array.Contracts;

namespace DataStructures.Array
{
    public class Array<T> : StaticArray<T>, IDynamicArray<T>
    {
        private int index = 0;

        // خاصية للحصول على عدد العناصر في المصفوفة
        public int Count => index;

        // خاصية للحصول على السعة الحالية للمصفوفة
        public int Capacity => Length;

        // دالة لإضافة عنصر جديد إلى المصفوفة
        public void Add(T value)
        {
            CheckDoubleArray(); // التحقق من السعة وتوسيع المصفوفة إذا لزم الأمر
            _innerArray[index] = value; // إضافة العنصر الجديد إلى المصفوفة
            index++; // زيادة عدد العناصر في المصفوفة
        }

        // دالة لإزالة عنصر من موضع محدد في المصفوفة
        public T RemoveAt(int position)
        {
            if (position < 0 || position > Count - 1)
            {
                throw new IndexOutOfRangeException(); // إذا كان الموضع غير صالح، يتم طرح استثناء
            }

            var removedItem = _innerArray[position]; // العنصر المزال من الموضع المحدد

            _innerArray[position] = default; // إزالة العنصر من المصفوفة

            // نقل العناصر الأخرى لتعويض العنصر المزال
            for (int i = position; i < Count - 1; i++)
            {
                Swap(i, i + 1);
            }
            index--; // تقليل عدد العناصر في المصفوفة
            ShrinkArray(); // التحقق من السعة وتقليص المصفوفة إذا لزم الأمر
            return removedItem; // إرجاع العنصر المزال
        }

        // دالة لتبديل قيمتين في المصفوفة
        public void Swap(int position1, int position2)
        {
            var temp = _innerArray[position1];
            _innerArray[position1] = _innerArray[position2];
            _innerArray[position2] = temp;
        }

        // دالة للتحقق من مضاعفة سعة المصفوفة وتوسيعها إذا لزم الأمر
        private void CheckDoubleArray()
        {
            if (index.Equals(_innerArray.Length))
            {
                var newArray = new T[_innerArray.Length * 2];
                for (int i = 0; i < _innerArray.Length; i++)
                {
                    newArray[i] = _innerArray[i];
                }
                _innerArray = newArray;
            }
        }

        // دالة للتحقق من تقليص سعة المصفوفة وضبطها إذا لزم الأمر
        private void ShrinkArray()
        {
            if (Count <= Capacity / 4)
            {
                var newArray = new T[Capacity / 2];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = _innerArray[i];
                }
                _innerArray = newArray;
            }
        }
    }
}
