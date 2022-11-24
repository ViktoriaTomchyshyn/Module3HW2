using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class PhoneRecord : IPhoneRecord, IComparer
    {
        private string _name;
        private string _phoneNumber;

        public PhoneRecord(string name, string phoneNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
        }

        public string Name
        {
            get { return _name; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public int Compare(object x, object y)
        {
            var name1 = ((IPhoneRecord)x).Name;
            var name2 = ((IPhoneRecord)y).Name;
            return name1.CompareTo(name2);
        }
    }
}
