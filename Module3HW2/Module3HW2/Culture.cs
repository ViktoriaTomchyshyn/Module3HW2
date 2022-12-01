using System.Collections;
using System.Collections.Generic;

namespace Module3HW2
{
    public class Culture : IEnumerable<string>
    {
        public Culture()
        {
            Name = string.Empty;
            Characters = null;
        }

        public Culture(string name, List<char> characters)
        {
            Name = name;
            Characters = characters;
        }

        public string Name { get; }
        public List<char> Characters { get; }

        public IEnumerator<string> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}