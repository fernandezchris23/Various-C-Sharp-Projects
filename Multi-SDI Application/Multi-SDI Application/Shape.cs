using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_SDI_Application
{
    class Shape
    {
        public Size shapeSize { get; set; }

        public Point shapeLoc { get; set; }

        public Color penColor { get; set; }

        public Color brushColor { get; set; }

        public Enum shape { get; set; }

        public Enum brushType { get; set; }

        public Enum penType { get; set; }

    }
}
