using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes.TSP
{
    public class TSPSpec
    {
        public TSPSpec(string name, IReadOnlyList<int> optimalTour, IReadOnlyList<Location> cities)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("name must not be null or whitespace", nameof(name));
            }

            Name = name;
            OptimalTour = optimalTour ?? throw new ArgumentNullException(nameof(optimalTour));
            Cities = cities ?? throw new ArgumentNullException(nameof(cities));
        }

        public string Name { get; }
        public IReadOnlyList<int> OptimalTour { get; }
        public IReadOnlyList<Location> Cities { get; }
    }
}
