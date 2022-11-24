using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public interface IMyCollection<T>
        where T : IPhoneRecord
    {
        void Add(T record);
        void Remove(T record);
        List<PhoneChapter> GetAll();
    }
}
