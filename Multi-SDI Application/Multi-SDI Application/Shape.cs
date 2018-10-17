using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Multi_SDI_Application
{
    [Serializable()]
    public class Shape : Component, ISerializable
    {
        public Shape(Enum shape, Enum bbType, Enum ppType, Color penColor, Color brushColor)
        {
            CurrentShape = shape;
            BrushType = bbType;
            PenType = ppType;
            ShapeId = 0;
            ShapeSize = new Size(10, 10);
            ShapeLoc = new Point(0, 0);
            PenColor = penColor;
            BrushColor = brushColor;
            IsBrush = true;
        }

        public int ShapeId { get; set; }

        public Enum CurrentShape { get; set; }

        public Enum BrushType { get; set; }

        public Enum PenType { get; set; }

        public Size ShapeSize { get; set; }

        public Point ShapeLoc { get; set; }

        public Color PenColor { get; set; }

        public Color BrushColor { get; set; }

        public Boolean IsBrush { get; set; }

        public Shape(SerializationInfo info, StreamingContext context)
        {
            ShapeId = (int)info.GetValue("ShapeId", typeof(int));
            IsBrush = info.GetBoolean("IsBrush");
            CurrentShape = (SerializableProperties.ShapeEnum)info.GetValue("CurrentShape", typeof(SerializableProperties.ShapeEnum));
            BrushType = (SerializableProperties.BrushEnum)info.GetValue("BrushType", typeof(SerializableProperties.BrushEnum));
            PenType = (SerializableProperties.PenEnum)info.GetValue("PenType", typeof(SerializableProperties.PenEnum));

            int width = (int)info.GetValue("Width", typeof(int));
            int height = (int)info.GetValue("Height", typeof(int));
            ShapeSize = new Size(width, height);

            int x = (int)info.GetValue("X", typeof(int));
            int y = (int)info.GetValue("Y", typeof(int));
            ShapeLoc = new Point(x, y);

            int pColorRGB = (int)info.GetValue("PenColor", typeof(int));
            int bColorRGB = (int)info.GetValue("BrushColor", typeof(int));
            PenColor = Color.FromArgb(pColorRGB);
            BrushColor = Color.FromArgb(bColorRGB);

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ShapeId", ShapeId);
            info.AddValue("CurrentShape", CurrentShape);
            info.AddValue("BrushType", BrushType);
            info.AddValue("PenType", PenType);
            info.AddValue("Width", ShapeSize.Width);
            info.AddValue("Height", ShapeSize.Height);

            info.AddValue("X", ShapeLoc.X);
            info.AddValue("Y", ShapeLoc.Y);

            info.AddValue("PenColor", PenColor.ToArgb());
            info.AddValue("BrushColor", BrushColor.ToArgb());
            info.AddValue("IsBrush", IsBrush);
        }

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

        public Pen GetPen()
        {
            switch (PenType)
            {
                case SerializableProperties.PenEnum.Solid:
                    Console.WriteLine("Using Solid pen");
                    return new Pen(GetBrush());

                case SerializableProperties.PenEnum.Dashed:
                    Console.WriteLine("Using Dashed pen");
                    float[] dashValues = { 5, 2, 15, 4 };
                    Pen pen = new Pen(GetBrush());
                    pen.DashPattern = dashValues;
                    return pen;

                default:
                    return new Pen(GetBrush());
            }
        }

        public Rectangle GetShape()
        {
            return new Rectangle(ShapeLoc, ShapeSize);
        }

        
    }
}
