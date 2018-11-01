using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace TextThreadProgram
{
    
    public class Text : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string stringText;
        private Font textFont;
        private Color bgColor;
        private Color textColor;
        private Point textLocation;
        private int z_Order;
        private Size textSize;
        private int textId;
        private float rotation;

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
            get { return textId; }
            set
            {
                this.textId = value;
                RaisePropertyChanged("TextId");
            }
        }

        public string StringText
        {
            get { return stringText; }
            set
            {
                this.stringText = value;
                RaisePropertyChanged("StringText");
            }
        }

        public int Z_Order
        {
            get { return z_Order; }
            set
            {
                this.z_Order = value;
                RaisePropertyChanged("Z_Order");
            }
        }

        public float Rotation
        {
            get { return rotation; }
            set
            {
                this.rotation = value;
                RaisePropertyChanged("Rotation");
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                this.textColor = value;
                RaisePropertyChanged("TextColor");
            }
        }

        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                this.bgColor = value;
                RaisePropertyChanged("BgColor");
            }
        }

        public Point TextLocation
        {
            get { return textLocation; }
            set
            {
                this.textLocation = value;
                RaisePropertyChanged("TextLocation");
            }
        }

        public Font TextFont
        {
            get { return textFont; }
            set
            {
                this.textFont = value;
                RaisePropertyChanged("TextFont");
            }
        }

        public Size TextSize
        {
            get { return textSize; }
            set
            {
                this.textSize = value;
                RaisePropertyChanged("TextSize");
            }
        }
    }
}
