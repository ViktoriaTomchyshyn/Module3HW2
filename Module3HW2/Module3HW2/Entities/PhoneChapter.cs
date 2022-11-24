using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class PhoneChapter : IComparer
    {
        public PhoneChapter(string name, List<IPhoneRecord> contacts)
        {
            Name = name;
            Contacts = contacts;
        }

        public string Name { get; }
        public List<IPhoneRecord> Contacts { get; }
        public int Compare(object x, object y)
        {
            var name1 = ((PhoneChapter)x).Name;
            var name2 = ((PhoneChapter)y).Name;
            return name1.CompareTo(name2);
        }
    }
}
