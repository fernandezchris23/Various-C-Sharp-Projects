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
        public enum ShapeEnum { Ellipse, Rectangle, PolyGon, Custom };
        public enum PenEnum { Solid, Dashed, Compound };
        public enum BrushEnum { Solid, Hatched, LinearGradient }

        public ShapeEnum Shape { get; set; }
        public PenEnum Pen { get; set; }
        public BrushEnum Brush { get; set; }

        public SerializableProperties()
        {
            Shape = ShapeEnum.Ellipse;
            Pen = PenEnum.Solid;
            Brush = BrushEnum.Solid;
        }
    }
}
