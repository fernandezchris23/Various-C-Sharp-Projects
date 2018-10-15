using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_SDI_Application
{
    [System.Serializable]
    class SerializableProperties
    {
        public enum Shape { Ellipse, Rectangle, Custom };
        public enum Pen { Solid, Dashed, Compound };
        public enum Brush { LinearGradient, Hatched, Solid }

        public Shape shape { get; set; }
        public Pen pen { get; set; }
        public Brush brush { get; set; }

        public SerializableProperties()
        {
            shape = Shape.Ellipse;
            pen = Pen.Solid;
            brush = Brush.Solid;
        }
    }
}
