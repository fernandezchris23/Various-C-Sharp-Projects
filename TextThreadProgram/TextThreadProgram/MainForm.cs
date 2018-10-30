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

        public MainForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            document = new Document();
            searchDialog = new SearchDialog();
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
            using(Graphics g = this.mainPanel.CreateGraphics())
            {
                g.DrawString(text.StringText, text.TextFont, Brushes.Aqua, text.TextLocation.X, text.TextLocation.Y);
            }
        }

        private void ReDrawDocument(Document document)
        {
            foreach(Text text in document)
                DrawText(text);
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Text text = new Text("Something", this.Font, Color.Black, Color.Red, new Point(e.X, e.Y));
            document.Add(text);
            DrawText(text);
            Console.WriteLine("Size of document is " + document.Count);

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

    }
}
