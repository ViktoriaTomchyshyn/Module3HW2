using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class PhoneChapter : IComparer
    {
        public PhoneChapter()
        {
            Name = string.Empty;
            Contacts = new List<IPhoneRecord>();
        }

        public PhoneChapter(string name, List<IPhoneRecord> contacts)
        {
            Name = name;
            if (contacts != null)
            {
                Contacts = contacts;
                Sort();
            }
            else
            {
                Contacts = new List<IPhoneRecord>();
            }
        }

        public string Name { get; }
        public List<IPhoneRecord> Contacts { get; }

        public void AddRecord(IPhoneRecord record)
        {
            Contacts.Add(record);
            Sort();
        }

        public void RemoveRecord(IPhoneRecord record)
        {
            Contacts.Remove(record);
        }

        public int Compare(object x, object y)
        {
            var name1 = ((PhoneChapter)x).Name;
            var name2 = ((PhoneChapter)y).Name;
            return name1.CompareTo(name2);
        }

        public void Sort()
        {
            Contacts.Sort();
        }

        public override string ToString()
        {
            string res = "\n" + Name + ":\n";
            foreach (var item in Contacts)
            {
                res += item;
            }

            return res;
        }
    }
}
