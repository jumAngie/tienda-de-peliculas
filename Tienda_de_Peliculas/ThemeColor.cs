using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Peliculas
{
    public static class ThemeColor
    {
        public static List<string> ColorList = new List<string>()
        {
           "#D14D57", "#C76B78", "#5F7BAF", "#003B5C", "#B24444",
            "#5BAE6E", "#9A3324", "#6A8CA1", "#C18D00", "#2CB2AC", "#6A006A",
            "#CC3F00", "#4E4969", "#FF7F50", "#4F8A4C", "#8F3E7A", "#C1815C",
            "#345A9D", "#C43B72", "#C2412D", "#BF7A86", "#6B35BC", "#D66088", "#993F3F"

        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
