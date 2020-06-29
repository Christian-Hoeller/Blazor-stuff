using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes
{
    public class WordStyle
    {
        public string BackgroundColor{ get; set; }
        public string Color{ get; set; }
        public override string ToString()
        {
            return $"color:{Color}; backgroung-color:{BackgroundColor};";
        }
    }
}
