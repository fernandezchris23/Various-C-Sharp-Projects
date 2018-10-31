using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextThreadProgram
{
    public partial class MainForm : Form
    {
        private string fileFilter;
        private Document document;
        private SearchDialog searchDialog;
        private OathDialog oathDialog;
        private AboutDialog aboutDialog;
        private Boolean isTyping;
        private Text currentText;
        private Text movingText;

        public MainForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            document = new Document();
            searchDialog = new SearchDialog();
            isTyping = false;
            currentText = new Text("", this.Font, Color.Black, Color.Red, new Point(0, 0), new Size(50, 50));
        }

        // key processing
        private void ChangeLocation(Keys key)
        {
            //  it should be the text location 
            Point location = currentText.TextLocation;
            //Handle arrow keys
            switch (key)
            {
                case Keys.Up:
                    --location.Y;
                    break;

                case Keys.Left:
                    --location.X;
                    break;

                case Keys.Down:
                    ++location.Y;
                    break;

                case Keys.Right:
                    ++location.X;
                    break;
            }
            currentText.TextLocation = location;
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Left:
                case Keys.Down:
                case Keys.Right:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        //Event handler for caps lock status strip  label
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if ((e.KeyCode & Keys.KeyCode) == Keys.CapsLock)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                    this.capsLockStatusStrip.Text = "Caps Lock: ON";
                else
                    this.capsLockStatusStrip.Text = "Caps Lock: OFF";
            }
            else if (IsInputKey(e.KeyCode))
            {
                ChangeLocation(e.KeyCode);
            }
        }

        private void SetBindings(Text data)
        {
            //this.DataBindings.Add("")
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchDialog.IsDisposed)
                searchDialog = new SearchDialog();

            // only allow one open at a time
            if (!searchDialog.Visible)
            {
                // open modelessly
                searchDialog.Show();
                // open off of the main form
                searchDialog.Location = new Point(this.Right, this.Top);
                // make the main form the owner of this dialog
                searchDialog.Owner = this;
            }

        }

        private void DrawText(Text text)
        {
            using(StringFormat format = new StringFormat())
            {
                format.Trimming = StringTrimming.Word;
                this.mainPanel.CreateGraphics().DrawString(text.StringText, text.TextFont, Brushes.Aqua, new Rectangle(text.TextLocation, text.TextSize), format);
            }
        }

        private void ReDrawDocument(Document document)
        {
            foreach(Text text in document)
                DrawText(text);
        }

        private Text Contains(Document docu, MouseEventArgs e)
        {
            foreach (Text text in docu)
                if ((e.X >= text.TextLocation.X && (e.X < text.TextLocation.X + text.TextSize.Width)) && e.Y >= text.TextLocation.Y && e.Y <= (text.TextLocation.Y + text.TextSize.Height))
                    return text;

            return null;
        }



        private Boolean mouseIsDown = false;
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            movingText = Contains(document, e);
            if(mouseIsDown && movingText != null)
            {
                movingText.TextLocation = new Point(e.X, e.Y);
                ReDrawDocument(document);
                this.mainPanel.Invalidate();
                this.Invalidate();
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

       

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Toggle
            if (isTyping)
            {
                document.Add(currentText);
                currentText = new Text("", this.Font, Color.Black, Color.Red, new Point(0, 0), new Size(50, 50));
                Console.WriteLine("Size of document = " + document.Count);
            }
            isTyping = !isTyping;

            currentText.TextLocation = new Point(e.X, e.Y);
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isTyping)
            {
                currentText.StringText += e.KeyChar;
                DrawText(currentText);
            }
        }

        private void openCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            object temp;
            if ((temp = Serializer.Deserialize(openFileDialog.FileName)) != null)
            {
                document = (Document)temp;
                ReDrawDocument(document);
            }
            else
                MessageBox.Show("Failed to load file");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = fileFilter;
            saveFileDialog.Title = "Save file";

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (Serializer.Serialize(saveFileDialog.FileName, document))
                MessageBox.Show(saveFileDialog.FileName + " saved succesfully");
            else
                MessageBox.Show("Failed to save file");
        }

        private void oathDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog = new OathDialog();
            oathDialog.Owner = this;        // the main form is the owner of the oath dialog  

            // manaully change location of modal dialog
            oathDialog.StartPosition = FormStartPosition.Manual;
            oathDialog.Location = new Point(this.Right, this.Bottom);

            oathDialog.ShowDialog();        // open modally
        }

        private void aboutDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog = new AboutDialog();
            aboutDialog.Owner = this;        // the main form is the owner of the about dialog  

            // manaully change location of modal dialog
            aboutDialog.StartPosition = FormStartPosition.Manual;
            aboutDialog.Location = new Point(this.Left, this.Bottom);

            aboutDialog.ShowDialog();        // open modally
        }
    }
}
