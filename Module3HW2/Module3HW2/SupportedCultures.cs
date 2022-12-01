using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW2
{
    public class SupportedCultures
    {
        public SupportedCultures(List<Culture> cultures)
        {
            Cultures = new List<Culture>(cultures);
        }

        public List<Culture> Cultures { get; }
    }
}
