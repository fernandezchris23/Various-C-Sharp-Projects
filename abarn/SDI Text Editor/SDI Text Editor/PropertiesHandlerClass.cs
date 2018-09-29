using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SDI_Text_Editor
{
    class PropertiesHandlerClass
    {
        public string fileText { get; set; }
        public string fileTitle { get; set; }
        public Color textColor { get; set; }
        public Color bgColor { get; set; }
        public Font textFont { get; set; }
        public Point formLoc { get; set; }
        public Size formSize { get; set; }

    }
}
