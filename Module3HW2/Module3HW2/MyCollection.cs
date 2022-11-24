using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class MyCollection :
        IMyCollection<IPhoneRecord>,
        IEnumerable<IPhoneRecord>
    {
        private Dictionary<string, List<IPhoneRecord>> _data;
        private CultureInfo _currentCulture;

        public MyCollection()
        {
            _data = new Dictionary<string, List<IPhoneRecord>>();
            _currentCulture = new CultureInfo("en-US");
            SetChapters();
        }

        public MyCollection(CultureInfo culture)
        {
            _data = new Dictionary<string, List<IPhoneRecord>>();
            _currentCulture = culture;
            SetChapters();
        }

        public void Add(IPhoneRecord record)
        {
            // int ignoreMe;
            //// choose chapter logic
            // if (string.Equals(record.Name.ToCharArray()[0], _currentCulture))
            // {
            //    _data["A - Z"].Add(record);
            // }
            // else if (int.TryParse((char)record.Name.ToCharArray()[0], out ignoreMe))
            // {

            // }
        }

        public List<PhoneChapter> GetAll()
        {
            var list = new List<PhoneChapter>();
            foreach (var item in _data)
            {
                list.Add(new PhoneChapter(item.Key, item.Value));
            }

            return list;
        }

        public IEnumerator<IPhoneRecord> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(IPhoneRecord record)
        {
            foreach (var item in _data.Values)
            {
                if (item.Contains(record))
                {
                    item.Remove(record);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void SetChapters()
        {
            _data.Add("A-Z", null);
            _data.Add("0-9", null);
            _data.Add("#", null);
        }
    }
}
