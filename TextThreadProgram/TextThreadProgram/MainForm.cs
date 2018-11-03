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
        public const string CAPS_ON = "Caps Lock: ON";
        public const string CAPS_OFF = "Caps Lock: OFF";

        private string fileFilter;
        private Document document;
        private Text currentText;
        private Text selectedText;

        private bool isTyping;
        private bool isDrawing;
        private bool isMoving;
        private bool isSelected;
        private bool mouseIsDown;
        private bool isOath, isAbout, isSearch, isTextOptions;

        //Used to give Z-order values. Since we don't want any two text on the same z-order (or else we won't know who will overlap who) we want it to be unique
        private int numText;

        public MainForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            document = new Document();
            isTyping = false;
            isDrawing = false;
            isMoving = false;
            isSelected = false;
            mouseIsDown = false;
            isOath = false;
            isAbout = false;
            isSearch = false;
            isTextOptions = false;
            currentText = GetCurrentText();
            DoubleBuffered = true;
            numText = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(Control.IsKeyLocked(Keys.CapsLock))
            {
                this.capsLockStatusStrip.Text = CAPS_ON;
            }
            else
            {
                this.capsLockStatusStrip.Text = CAPS_OFF;
            }
        }

        //Event handler for caps lock status strip  label
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.KeyCode) == Keys.CapsLock)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                    this.capsLockStatusStrip.Text = CAPS_ON;
                else
                    this.capsLockStatusStrip.Text = CAPS_OFF;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isTyping && currentText != null)
            {
                currentText.StringText += e.KeyChar;
                document.Add(currentText);
                ReDrawDocument(document);
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            if ((currentText = Contains(document, e)) != null)
            {
                if (e.Button == MouseButtons.Right)
                    openTextOptions();
                else
                {
                    isSelected = true;
                    selectedText = document.GetText(new Point(e.X, e.Y));
                }       
            }
            else
            {
                currentText = GetCurrentText();
            }

        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown && isSelected)
            {
                isMoving = true;
                document.moveText(selectedText, new Point(e.X, e.Y));
                this.mainPanel.Invalidate();
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelected && isMoving)
            {
                mouseIsDown = false;
                isDrawing = false;
                isMoving = false;
                isSelected = false;
                ReDrawDocument(document);
                selectedText = null;
            }
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (isTyping)
            {
                currentText.Z_Order = numText++;
                document.Add(currentText);
                currentText = GetCurrentText();
            }
            isTyping = !isTyping; //Toggle

            if (currentText != null)
                currentText.TextLocation = new Point(e.X, e.Y);
            else
            {

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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                isSearch = true;
                SearchDialog searchDialog = new SearchDialog();
                searchDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                searchDialog.Show();
                // open off of the main form
                searchDialog.StartPosition = FormStartPosition.Manual;
                searchDialog.Location = new Point(this.Right, this.Top);
                // make the main form the owner of this dialog
                searchDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOath)
            {
                isOath = true;
                OathDialog oathDialog = new OathDialog();
                oathDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                oathDialog.Show();
                // open off of the main form
                oathDialog.StartPosition = FormStartPosition.Manual;
                oathDialog.Location = new Point(this.Right, this.Bottom);
                // make the main form the owner of this dialog
                oathDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isAbout)
            {
                isAbout = true;
                AboutDialog aboutDialog = new AboutDialog();
                aboutDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                aboutDialog.Show();
                // open off of the main form
                aboutDialog.StartPosition = FormStartPosition.Manual;
                aboutDialog.Location = new Point(this.Left, this.Bottom);
                // make the main form the owner of this dialog
                aboutDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Console.WriteLine("isDrawing=" + isDrawing + " isMoving=" + isMoving + "mouseIsDown=" + mouseIsDown);
            if (isDrawing)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                       // MoveText(currentText.TextLocation.X - 10, currentText.TextLocation.Y);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");
                        break;
                    case Keys.Right:
                       // MoveText(currentText.TextLocation.X + 10, currentText.TextLocation.Y);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");

                        break;
                    case Keys.Up:
                      //  MoveText(currentText.TextLocation.X, currentText.TextLocation.Y - 10);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");

                        break;
                    case Keys.Down:
                       // MoveText(currentText.TextLocation.X, currentText.TextLocation.Y + 10);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");

                        break;
                }
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        private Text GetCurrentText()
        {
            return new Text("", new Font("Times New Roman", 20.0f), Color.Black, Color.Red, new Point(0, 0), new Size(100, 100));
        }

        private void DrawText(Text text)
        {
            using (StringFormat format = new StringFormat())
            {
                format.Trimming = StringTrimming.Word;
                this.mainPanel.CreateGraphics().DrawString(text.StringText, text.TextFont, new SolidBrush(text.TextColor), new Rectangle(text.TextLocation, text.TextSize), format);
            }
        }

        private void ReDrawDocument(Document document)
        {
            foreach (Text text in document)
                DrawText(text);
        }

        private Text Contains(Document docu, MouseEventArgs e)
        {
            foreach (Text text in docu)
                if ((e.X >= text.TextLocation.X && (e.X < text.TextLocation.X + text.TextSize.Width)) && e.Y >= text.TextLocation.Y && e.Y <= (text.TextLocation.Y + text.TextSize.Height))
                    return text;

            return null;
        }

        private void SetBindings(Text data)
        {
            //this.DataBindings.Add("")
        }

        private void OwnedFormClosed(object dialog, FormClosedEventArgs e)
        {
            if(dialog is SearchDialog)
            {
                isSearch = false;
            }
            else if(dialog is AboutDialog)
            {
                isAbout = false;
            }
            else if(dialog is OathDialog)
            {
                isOath = false;
            }
            else if(dialog is TextOptions)
            {
                isTextOptions = false;
            }
        }

        private void openTextOptions()
        {
            if (!isTextOptions)
            {
                isTextOptions = true;
                TextOptions textOptionsDialog = new TextOptions();
                textOptionsDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                textOptionsDialog.Show();
                // make the main form the owner of this dialog
                textOptionsDialog.Owner = this;
                textOptionsDialog.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                return;
            }
        }
    }
}
