using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextThreadProgram
{
    class Text
    {
        public string StringText { get; set; }

        public int Z_Order { get; set; }

        public Color TextColor { get; set; }

        public Color BgColor { get; set; }

        public Point TextLocation { get; set; }

        public Font TextFont { get; set; }

        public float Rotation { get; set; }
    }
}
