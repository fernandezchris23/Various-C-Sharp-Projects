using System.Drawing;

namespace SDI_Text_Editor
{
    [System.Serializable]
    public class TextProperties
    {
        public string fileText { get; set; }
        public string fileTitle { get; set; }
        public Color textColor { get; set; }
        public Color backColor { get; set; }
        public Font textFont { get; set; }
        public Point formLoc { get; set; }
        public Size formSize { get; set; }

        public TextProperties()
        {
            textColor = Color.Black;
            backColor = Color.White;
            textFont = new Font("Times New Roman", 12.0f);
        }

    }
}
