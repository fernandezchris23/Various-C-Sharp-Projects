using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFormFiles
{
    interface ShapeInterface
    {
        int ellipseWidth { get; set; }
        int rectHeight { get; set; }

        float shapeRatio { get; set; }
    }
}
