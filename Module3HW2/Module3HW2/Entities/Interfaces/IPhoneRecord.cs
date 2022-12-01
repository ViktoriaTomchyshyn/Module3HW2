using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public interface IPhoneRecord : IComparable<IPhoneRecord>
    {
        string Name { get; }
        string PhoneNumber { get; }
    }
}
