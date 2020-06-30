using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes
{
    public class WordSets
    {
        private Dictionary<string, string> wordSets = new Dictionary<string, string>()
        {
            {"german", "hallo geht gehen vielleicht wie sein bin Hallo Haus Frau Motor Maus"},
            {"english", "hello go went going eventually maybe might how be seen motor house mouse sink"}
        };

        public List<string> GetSetByLanguage(string language)
        {
            wordSets.TryGetValue(language, out string wordSet);
            List<string> words = wordSet.Split(" ").ToList();
            return words;
        }
    }
}
