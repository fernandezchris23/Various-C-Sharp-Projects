using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TextThreadProgram
{
    class Text : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public int TextId
        {
            get { return TextId; }
            set
            {
                this.TextId = value;
                OnChange("TextID");
            }
        }

        public string StringText
        {
            get { return StringText; }
            set
            {
                this.StringText = value;
                OnChange("StringText");
            }
        }

        public int Z_Order
        {
            get { return Z_Order; }
            set
            {
                this.Z_Order = value;
                OnChange("Z_Order");
            }
        }

        public Color TextColor
        {
            get { return TextColor; }
            set
            {
                this.TextColor = value;
                OnChange("TextColor");
            }
        }

        public Color BgColor
        {
            get { return BgColor; }
            set
            {
                this.BgColor = value;
                OnChange("BgColor");
            }
        }

        public Point TextLocation
        {
            get { return TextLocation; }
            set
            {
                this.TextLocation = value;
                OnChange("TextLocation");
            }
        }

        public Font TextFont
        {
            get { return TextFont; }
            set
            {
                this.TextFont = value;
                OnChange("TextFont");
            }
        }

        public float Rotation
        {
            get { return Rotation; }
            set
            {
                this.Rotation = value;
                OnChange("Rotation");
            }
        }
    }
}
