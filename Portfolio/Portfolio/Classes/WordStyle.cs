using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Classes
{
    public class WordStyle
    {
        public WordStyle(Color backgroundColor, Color color)
        {
            Color = color;
            BackgroundColor = backgroundColor;
        }
        public Color BackgroundColor { get; set; }
        public Color Color { get; set; }
        public override string ToString()
        {
            return $"color:{Color.Name}; background-color:{BackgroundColor.Name};";
        }
    }
}
