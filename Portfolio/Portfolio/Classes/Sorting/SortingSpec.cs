using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes.Sorting
{
    public class SortingSpec
    {
        public SortingSpec(List<int> numbersList, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("name must not be null");
            }
            NumbersList = numbersList ?? throw new ArgumentNullException(nameof(numbersList));
            Name = name;
        }

        public List<int> NumbersList { get; set; }
        public string Name { get; set; }
    }
}
