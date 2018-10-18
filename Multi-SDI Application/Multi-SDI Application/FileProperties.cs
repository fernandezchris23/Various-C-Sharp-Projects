using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_SDI_Application
{
    public class FileProperties : INotifyPropertyChanged
    {
        private Size shapeSize;
        private Point shapeLoc;
        private Color penColor;
        private Color brushColor;
        private string penType;
        private string brushType;
        private string shapeType;

        public FileProperties()
        {
            ShapeWidth = 0;
            ShapeHeight = 0;
            ShapeX = 0;
            ShapeY = 0;

        }

        public int ShapeWidth
        {
            get { return shapeSize.Width; }

            set
            {
                if (shapeSize.Width == value)
                {
                    return;
                }
                else
                {
                    this.shapeSize.Width = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Width"));
                    }
                }
            }
        }

        public int ShapeHeight
        {
            get { return shapeSize.Height; }

            set
            {
                if (shapeSize.Height == value)
                {
                    return;
                }
                else
                {
                    this.shapeSize.Height = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Height"));
                    }
                }
            }
        }

        public int ShapeX
        {
            get { return shapeLoc.X; }

            set
            {
                if (shapeLoc.X == value)
                {
                    return;
                }
                else
                {
                    this.shapeLoc.X = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("X"));
                    }
                }
            }
        }

        public int ShapeY
        {
            get { return shapeLoc.Y; }

            set
            {
                if (shapeLoc.Y == value)
                {
                    return;
                }
                else
                {
                    this.shapeLoc.Y = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Y"));
                    }
                }
            }
        }

        public Color PenColor
        {
            get { return penColor; }

            set
            {
                if (penColor == value)
                {
                    return;
                }
                else
                {
                    this.penColor = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("PenColor"));
                    }
                }
            }
        }

        public Color BrushColor
        {
            get { return brushColor; }

            set
            {
                if (brushColor == value)
                {
                    return;
                }
                else
                {
                    this.brushColor = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BrushColor"));
                    }
                }
            }
        }

        public string PenType
        {
            get { return penType; }

            set
            {
                if (penType == value)
                {
                    return;
                }
                else
                {
                    this.penType = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("PenType"));
                    }
                }
            }
        }

        public string BrushType
        {
            get { return brushType; }

            set
            {
                if (brushType == value)
                {
                    return;
                }
                else
                {
                    this.brushType = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BrushType"));
                    }
                }
            }
        }

        public string ShapeType
        {
            get { return shapeType; }

            set
            {
                if (shapeType == value)
                {
                    return;
                }
                else
                {
                    this.shapeType = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("ShapeType"));
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
