using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        private List<PhoneChapter> _data;
        private SupportedCultures _supportedCultures;
        private Culture _currentCulture;

        public MyCollection()
        {
            _data = new List<PhoneChapter>();
            _currentCulture = new Culture("English", "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray().ToList());
            var supportedCultures = new List<Culture>();
            supportedCultures.Add(_currentCulture);
            _supportedCultures = new SupportedCultures(supportedCultures);
            SetChapters();
        }

        public MyCollection(SupportedCultures sc, Culture culture)
        {
            _data = new List<PhoneChapter>();
            _currentCulture = culture;
            _supportedCultures = sc;
            SetChapters();
        }

        public void Add(IPhoneRecord record)
        {
            int ignoreMe;

            // choose chapter logic
            if (_supportedCultures.Cultures.Contains(_currentCulture) &&
                _currentCulture.Characters.Contains(record.Name.ToCharArray()[0]))
            {
                _data[0].AddRecord(record);
            }
            else if (int.TryParse(record.Name.ToCharArray()[0].ToString(), out ignoreMe))
            {
                _data[1].AddRecord(record);
            }
            else
            {
                _data[2].AddRecord(record);
            }
        }

        public List<PhoneChapter> GetAll()
        {
            return _data;
        }

        public IEnumerator<IPhoneRecord> GetEnumerator()
        {
            var data = new List<IPhoneRecord>();
            foreach (var item in _data)
            {
                item.Sort();
                data.AddRange(item.Contacts);
            }

            return new MyCollectionEnumerator<IPhoneRecord>(data.ToArray());
        }

        public void Remove(IPhoneRecord record)
        {
            foreach (var item in _data)
            {
               if (item.Contacts.Contains(record))
               {
                  item.RemoveRecord(record);
               }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var data = new List<IPhoneRecord>();
            foreach (var item in _data)
            {
                data.AddRange(item.Contacts);
            }

            return new MyCollectionEnumerator<IPhoneRecord>(data.ToArray());
        }

        public override string ToString()
        {
            string res = string.Empty;
            foreach (var item in _data)
            {
                res += item.ToString();
            }

            return res;
        }

        private void SetChapters()
        {
            _data.Add(new PhoneChapter("A-Z", null));
            _data.Add(new PhoneChapter("0-9", null));
            _data.Add(new PhoneChapter("#", null));
        }
    }
}
