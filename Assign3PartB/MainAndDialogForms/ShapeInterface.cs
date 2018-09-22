using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAndDialogForms
{
    interface ShapeInterface
    {
        int EllipseWidth { get; set; }

        int RectHeight { get; set; }

        float ShapeRatio { get; set; }

        event EventHandler applyBttnClick;
    }
}
