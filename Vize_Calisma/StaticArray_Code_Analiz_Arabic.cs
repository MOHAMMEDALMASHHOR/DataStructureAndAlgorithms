using System.Collections;
using DataStructures.Array.Contracts;

// تعريف الكلاس وتطبيق واجهة IArray<T> و IEnumerable
public class StaticArray<T> : IArray<T>, IEnumerable
{
    protected T[] _innerArray; // مصفوفة العناصر

    // البناء الأولي للمصفوفة مع تحديد حجمها الابتدائي
    public StaticArray()
    {
        _innerArray = new T[4];
    }

    // البناء الأولي للمصفوفة باستخدام عناصر مأخوذة من مصفوفة أو تجميعة
    public StaticArray(IEnumerable<T> collection)
    {
        _innerArray = new T[collection.Count()]; // إنشاء مصفوفة بحجم مطابق لعدد العناصر في التجميعة
        int i = 0;
        foreach (var item in collection)
        {
            SetItem(i, item); // تعيين كل عنصر من التجميعة في موضعه المناسب في المصفوفة
            i++;
        }
    }

    // خاصية للحصول على طول المصفوفة
    public int Length => _innerArray.Length;

    // دالة للحصول على عنصر في موضع محدد
    public T GetItem(int index)
    {
        CheckIndex(index); // التحقق من صلاحية الموضع
        return _innerArray[index];
    }

    // دالة لتعيين قيمة لعنصر في موضع محدد
    public void SetItem(int index, T value)
    {
        CheckIndex(index); // التحقق من صلاحية الموضع
        _innerArray[index] = value;
    }

    // دالة لتحديد صحة الموضع
    protected void CheckIndex(int index)
    {
        if (index < 0 || index >= _innerArray.Length)
            throw new IndexOutOfRangeException(); // إذا كان الموضع غير صالح، يتم طرح استثناء
    }

    // دالة للحصول على مُعِيِّن للمصفوفة
    public IEnumerator GetEnumerator()
    {
        return _innerArray.GetEnumerator(); // استرجاع المعين للمصفوفة
    }
}
