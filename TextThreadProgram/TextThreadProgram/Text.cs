using System;
using System.Drawing;
using System.Runtime.Serialization;

namespace TextThreadProgram
{
    [Serializable()]
    public class Text : ISerializable
    {
        public Text(string stringText, Font textFont, Color textColor, Color bgColor, Point textLocation, Size textSize)
        {
            StringText = stringText;
            TextFont = textFont;
            TextColor = textColor;
            BgColor = bgColor;
            TextLocation = textLocation;
            TextSize = textSize;
        }

        public Text(SerializationInfo info, StreamingContext context)
        {
            TextId = info.GetInt32("TextId");
            StringText = info.GetString("StringText");
            Z_Order = info.GetInt32("Z_Order");
            Rotation = info.GetSingle("Rotation");
            TextColor = Color.FromArgb(info.GetInt32("TextColor"));
            BgColor = Color.FromArgb(info.GetInt32("BgColor"));
            TextLocation = new Point(info.GetInt32("X"), info.GetInt32("Y"));
            TextFont = new Font(info.GetString("familyName"), info.GetInt32("emSize"));
            TextSize = new Size(info.GetInt32("Width"), info.GetInt32("Height"));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("TextId", TextId);
            info.AddValue("StringText", StringText);
            info.AddValue("Z_Order", Z_Order);
            info.AddValue("Rotation", Rotation);

            //Size
            info.AddValue("Width", TextSize.Width);
            info.AddValue("Height", TextSize.Height);

            info.AddValue("TextColor", TextColor.ToArgb());
            info.AddValue("BgColor", BgColor.ToArgb());

            //Point
            info.AddValue("X", TextLocation.X);
            info.AddValue("Y", TextLocation.Y);

            //Font (string familyName, float emSize);
            info.AddValue("familyName", TextFont.FontFamily.Name);
            info.AddValue("emSize", TextFont.Size);
        }

        public int TextId { get; set; }

        public string StringText { get; set; }

        public int Z_Order { get; set; }

        public float Rotation { get; set; }

        public Color TextColor { get; set; }

        public Color BgColor { get; set; }

        public Point TextLocation { get; set; }

        public Font TextFont { get; set; }

        public Size TextSize { get; set; }
    }
}
