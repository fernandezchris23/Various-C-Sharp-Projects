using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Windows.Forms;
using System.Drawing;

namespace SDI_Text_Editor
{
    public partial class EditorForm : Form
    {
        private TextProperties textProperties;
        private PrefsDialog prefDialog;
        private OathDialog oathDialog;
        private AboutDialog aboutDialog;
        private bool fileIsSaved;
        private bool formIsClosing;

        //Default constructor
        public EditorForm()
        {
            //Create default text properties
            textProperties = new TextProperties();
            fileIsSaved = false;
            aboutDialog = new AboutDialog();

            InitializeComponent();

            this.CenterToScreen();
            //Update the editor box since default text properties aren't 
            //the same as winforms default text (Times new roman, 12pt)
            updateEditorBox();
        }

        //Toolstrip Preferences button creates a new Preferences Dialog
        private void preferencesButton_Click(object sender, EventArgs e)
        {
            //Pass the current text properties to prefsDialog
            prefDialog = new PrefsDialog(textProperties);
            prefDialog.applyBttnClick += new EventHandler(updateValues);
            prefDialog.Show();
        }

        //Update values that can be changed from the preferences menu
        public void updateValues(object sender, EventArgs e)
        {
            //If any value is different, the file is not saved
            if (this.textProperties.textColor != textProperties.textColor &&
                 this.textProperties.textFont != textProperties.textFont &&
                 this.textProperties.backColor != textProperties.backColor
                )
                fileIsSaved = false;

            this.textProperties.textColor = textProperties.textColor;
            this.textProperties.textFont = textProperties.textFont;
            this.textProperties.backColor = textProperties.backColor;

            //Update the text box in Editor form to reflect the changes
            updateEditorBox();
        }
        
        //Update the text box in the editor form to reflect preferences menu changes
        public void updateEditorBox()
        {
            this.textEditorBox.ForeColor = textProperties.textColor;
            this.textEditorBox.Font = textProperties.textFont;
            this.textEditorBox.BackColor = textProperties.backColor;
        }

        //Save a file. Shows the saveFileDialog, and saves to the inputted filename
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //First save any and all changes to the file's text.
            textProperties.fileText = this.textEditorBox.Text;

            //If user doesn't click OK on saveFileDialog, don't do anything
            if (this.saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            //Else, save to the inputted filename
            string filename = this.saveFileDialog.FileName;
            this.Text = Path.GetFileNameWithoutExtension(this.saveFileDialog.FileName);
            textProperties.fileTitle = this.Text; //Saves name of file to properties class
            textProperties.formLoc = this.DesktopLocation;
            fileIsSaved = true;

            SaveToFile(textProperties, filename);
        }

        //Open a file. Shows openFileDialog, and opens the inputted filename
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If user doesn't click OK on openFileDialog, don't do anything
            if (this.openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            //Else, get filename from openFileDialog, and open the file
            string filename = this.openFileDialog.FileName;
            OpenFile(filename);

            //Update the text box in editor form to the file we just opened
            this.textEditorBox.Text = textProperties.fileText;
            this.Text = textProperties.fileTitle; //Changes title of form to file name
            this.DesktopLocation = textProperties.formLoc;
            fileIsSaved = true; //File that was just opened is already up to date

            updateEditorBox();
        }

        //Save a file using binaryFormatter
        public void SaveToFile(TextProperties properties, String filename)
        {
            //IO file stream to provide to the binary formatter
            Stream stream = File.OpenWrite(filename);
            
            //Instantiate binary formatter, then serialize (save) provided TextProperties
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, properties);

            //Clean up
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        //Open a file using binaryFormatter
        public void OpenFile(String filename)
        {
            //IO file stream to provide to the binary formatter
            FileStream stream = File.Open(filename, FileMode.Open);

            //Instantiate binary formatter
            BinaryFormatter formatter = new BinaryFormatter();
            
            //Create object by deserializing (opening) the file from filestream.
            object obj = formatter.Deserialize(stream);

            //Cast object to TextProperties class
            textProperties = (TextProperties)obj;

            //Clean up
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lengthOfSelection = textEditorBox.SelectionLength;

            //Save data to clipboard and then change text in textbox to everything minus the selection
            Clipboard.SetData(DataFormats.Text, textEditorBox.SelectedText);
            textEditorBox.Text = textEditorBox.Text.Remove(textEditorBox.SelectionStart, lengthOfSelection);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textEditorBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes text in textbox to the text after inserting what was in the clipboard at the current cursor location
            textEditorBox.Text = textEditorBox.Text.Insert(textEditorBox.SelectionStart, Clipboard.GetData(DataFormats.Text).ToString());
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditorForm_Move(object sender, EventArgs e)
        {
            fileIsSaved = false; //If location of form changed, then the properties isn't up to date and needs to be saved
        }

        private void textEditorBox_TextChanged(object sender, EventArgs e)
        {
            fileIsSaved = false;
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!fileIsSaved)
            {
                    formIsClosing = true;
                    e.Cancel = ExitPrompt();
            }
        }

        private Boolean ExitPrompt()
        {
            return MessageBox.Show("Are you sure you want to exit without saving?","Your work was not saved.", MessageBoxButtons.YesNo) == DialogResult.No;
        }


        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog = new OathDialog();
            oathDialog.Owner = this;        // the main form is the owner of the oath dialog  

            oathDialog.StartPosition = FormStartPosition.Manual;
            oathDialog.Location = new Point(this.Right, this.Top);

            oathDialog.ShowDialog();        // open modally
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutDialog.IsDisposed)
                aboutDialog = new AboutDialog();

            if (!aboutDialog.Visible)
            {
                aboutDialog.Show();
                aboutDialog.Location = new Point(this.Left, this.Bottom);
                aboutDialog.Owner = this;
            }
        }

        private void EditorForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void EditorForm_Deactivate(object sender, EventArgs e)
        {
            if (!formIsClosing)
            {
                this.Opacity = 0.5;
            }
        }
    }
}
