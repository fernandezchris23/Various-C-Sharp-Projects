using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace TextThreadProgram
{
    
    public class Text : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
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

        public int TextId
        {
            get { return TextId; }
            set
            {
                TextId = value;
                RaisePropertyChanged("TextId");
            }
        }

        public string StringText
        {
            get { return StringText; }
            set
            {
                StringText = value;
                RaisePropertyChanged("StringText");
            }
        }

        public int Z_Order
        {
            get { return Z_Order; }
            set
            {
                Z_Order = value;
                RaisePropertyChanged("Z_Order");
            }
        }

        public float Rotation
        {
            get { return Rotation; }
            set
            {
                Rotation = value;
                RaisePropertyChanged("Rotation");
            }
        }

        public Color TextColor
        {
            get { return TextColor; }
            set
            {
                TextColor = value;
                RaisePropertyChanged("TextColor");
            }
        }

        public Color BgColor
        {
            get { return BgColor; }
            set
            {
                BgColor = value;
                RaisePropertyChanged("BgColor");
            }
        }

        public Point TextLocation
        {
            get { return TextLocation; }
            set
            {
                TextLocation = value;
                RaisePropertyChanged("TextLocation");
            }
        }

        public Font TextFont
        {
            get { return TextFont; }
            set
            {
                TextFont = value;
                RaisePropertyChanged("TextFont");
            }
        }

        public Size TextSize
        {
            get { return TextSize; }
            set
            {
                TextSize = value;
                RaisePropertyChanged("TextSize");
            }
        }
    }
}
