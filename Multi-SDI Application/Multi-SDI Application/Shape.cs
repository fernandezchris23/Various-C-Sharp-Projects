using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Multi_SDI_Application
{
    public class Shape
    {
        public Shape(Enum shape, Enum BrushType, Enum Pentype)
        {
            this.CurrentShape = shape;
            this.BrushType = BrushType;
            this.PenType = PenType;
            this.ShapeId = 0;
            this.ShapeSize = new Size(10, 10);
            this.ShapeLoc = new Point(0, 0);
            this.PenColor = Color.Black;
            this.BrushColor = Color.Black;
        }

        public Shape(Enum shape): this(shape, SerializableProperties.BrushEnum.Solid, SerializableProperties.PenEnum.Solid) {}

        public int ShapeId { get; set; }

        public Enum CurrentShape { get; set; }

        public Enum BrushType { get; set; }

        public Enum PenType { get; set; }

        public Size ShapeSize { get; set; }

        public Point ShapeLoc { get; set; }

        public Color PenColor { get; set; }

        public Color BrushColor { get; set; }

        public Brush GetBrush()
        {
            switch (BrushType)
            {
                case SerializableProperties.BrushEnum.Solid:
                    Console.WriteLine("Using Solid brush");
                    return new SolidBrush(BrushColor);

                case SerializableProperties.BrushEnum.Hatched:
                    Console.WriteLine("Using Hatched brush");
                    return new HatchBrush(HatchStyle.LightVertical, BrushColor, Color.DarkBlue);

                default:
                    return new LinearGradientBrush(new Point(10, 10), new Point(20, 20), BrushColor, Color.Blue);
            }
        }

        public Rectangle GetShape()
        {
            return new Rectangle(ShapeLoc, ShapeSize);
        }

    }
}
