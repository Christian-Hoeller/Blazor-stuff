using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes
{
    public class WordSetSettings
    {
        public WordSetSettings(string language, int wordAmount)
        {
            Language = language;
            WordAmount = wordAmount;
        }

        public string Language { get; set; }
        public int WordAmount { get; set; }
    }
}
