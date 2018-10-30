using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TextThreadProgram
{
    public class Text
    {
        public Text(string stringText, Font textFont, Color textColor, Color bgColor, Point textLocation)
        {
            StringText = stringText;
            TextFont = textFont;
            TextColor = textColor;
            BgColor = bgColor;
            TextLocation = textLocation;
        }

        public int TextId { get; set; }

        public string StringText { get; set; }

        public Color TextColor { get; set; }

        public Color BgColor { get; set; }

        public Point TextLocation { get; set; }

        public Font TextFont { get; set; }

        public int Z_Order { get; set; }

        public float Rotation { get; set; }
    }
}
