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
        private Text currentText;
        private bool isTyping;
        private bool isDrawing;
        private bool isMoving;
        private bool mouseIsDown;


        public MainForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            document = new Document();
            searchDialog = new SearchDialog();
            isTyping = false;
            isDrawing = false;
            isMoving = false;
            mouseIsDown = false;
            currentText = GetCurrentText();
            DoubleBuffered = true;
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
                searchDialog.Location = new Point(this.Top, this.Right);
                // make the main form the owner of this dialog
                searchDialog.Owner = this;
            }

        }

        private void DrawText(Text text)
        {
            using(StringFormat format = new StringFormat())
            {
                format.Trimming = StringTrimming.Word;
                this.mainPanel.CreateGraphics().DrawString(text.StringText, text.TextFont, new SolidBrush(text.TextColor), new Rectangle(text.TextLocation, text.TextSize), format);
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

        private void MoveText(int x, int y)
        {
            currentText.TextLocation = new Point(x, y);
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            currentText = Contains(document, e); //Get clicked text
            if ((currentText = Contains(document, e)) != null)
            {
                isDrawing = true;
            }
            else
            {
                isDrawing = false;
                currentText = GetCurrentText();
            }

        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseIsDown && isDrawing)
            {
                isMoving = true;
                MoveText(e.X, e.Y);
                this.mainPanel.Invalidate();
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && isMoving)
            {
                mouseIsDown = false;
                isDrawing = false;
                isMoving = false;
                ReDrawDocument(document);
            }
        }

        private Text GetCurrentText()
        {
            return new Text("", new Font("Times New Roman", 20.0f), Color.Black, Color.Red, new Point(0, 0), new Size(100, 100));
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
                        MoveText(currentText.TextLocation.X - 10, currentText.TextLocation.Y);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");
                        break;
                    case Keys.Right:
                        MoveText(currentText.TextLocation.X + 10, currentText.TextLocation.Y);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");

                        break;
                    case Keys.Up:
                        MoveText(currentText.TextLocation.X, currentText.TextLocation.Y - 10);
                        ReDrawDocument(document);
                        Console.WriteLine("Drawed");

                        break;
                    case Keys.Down:
                        MoveText(currentText.TextLocation.X, currentText.TextLocation.Y + 10);
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

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (isTyping)
            {
                document.Add(currentText);
                currentText = GetCurrentText();
            }
            isTyping = !isTyping; //Toggle

            if(currentText != null)
                currentText.TextLocation = new Point(e.X, e.Y);
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

        private void MainForm_Load(object sender, EventArgs e)
        {

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
