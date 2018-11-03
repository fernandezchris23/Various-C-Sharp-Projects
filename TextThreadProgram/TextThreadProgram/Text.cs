using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;

namespace TextThreadProgram
{
    [Serializable()]
    public class Text : ISerializable, INotifyPropertyChanged
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

        private string stringText;
        private int zOrder;
        private float rotation;
        private Color textColor;
        private Color bgColor;
        private Point textLocation;
        private Font textFont;
        private Size textSize;

        public string StringText
        {
            get { return stringText; }
            set
            {

                if (stringText == value)
                {
                    return;
                }
                else
                {
                    stringText = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("StringText"));
                    }
                }
            }
        }

        public int Z_Order
        {
            get { return zOrder; }
            set
            {

                if (zOrder == value)
                {
                    return;
                }
                else
                {
                    zOrder = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ZOrder"));
                    }
                }
            }
        }

        public float Rotation
        {
            get { return rotation; }
            set
            {

                if (rotation == value)
                {
                    return;
                }
                else
                {
                    rotation = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Rotation"));
                    }
                }
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {

                if (textColor == value)
                {
                    return;
                }
                else
                {
                    textColor = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TextColor"));
                    }
                }
            }
        }

        public Color BgColor
        {
            get { return bgColor; }
            set
            {

                if (bgColor == value)
                {
                    return;
                }
                else
                {
                    bgColor = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BgColor"));
                    }
                }
            }
        }

        public int TextLocationX { get; set; }
        public int TextLocationY { get; set; }

        public Point TextLocation
        {
            get { return textLocation; }
            set
            {
                 textLocation = value;
                 if (PropertyChanged != null)
                 {
                     PropertyChanged(this, new PropertyChangedEventArgs("TextLocation"));
                 }
            }
        }

        public Font TextFont
        {
            get { return textFont; }
            set
            {

                if (textFont == value)
                {
                    return;
                }
                else
                {
                    textFont = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TextFont"));
                    }
                }
            }
        }

        public Size TextSize
        {
            get { return textSize; }
            set
            {

                if (textSize == value)
                {
                    return;
                }
                else
                {
                    textSize = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("TextSize"));
                    }
                }
            }
        }

        #region INotifyPropertyChanged Members

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
