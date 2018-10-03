using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;
using System.Windows.Forms;

namespace SDI_Text_Editor
{
    public partial class EditorForm : Form
    {
        private TextProperties textProperties;
        private PrefsDialog prefDialog;
        private bool fileIsSaved;

        public const string RECENT_FILENAMES = "recentFiles.txt"; //Name of file to store list of recent files

        //Default constructor
        public EditorForm()
        {
            //Create default text properties
            textProperties = new TextProperties();

            //Initializers
            fileIsSaved = false;

            InitializeComponent();

            this.CenterToScreen();

            readRecentList();

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

            //Used for building Open Recent list
            updateRecentList(filename);

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

            //Used for building Open Recent list
            updateRecentList(filename);

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

            }
        }

        private void updateRecentList(string fileName)
        {
            StreamWriter openRecentStream;

            openRecentStream = new StreamWriter(RECENT_FILENAMES, true);
            openRecentStream.WriteLine(fileName);
            openRecentStream.Close();
            readRecentList();
        }

        private void readRecentList()
        {
            if(!File.Exists(RECENT_FILENAMES))
            {
                File.Create(RECENT_FILENAMES).Close();
            }

            StreamReader openRecentStream;
            string lineOfFile;
            int numLinesInFile = 0;

            try {
                openRecentStream = new StreamReader(RECENT_FILENAMES);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("File: " + RECENT_FILENAMES + " was not found. Please Create the file.");
                return;
            }

            while (openRecentStream.ReadLine() != null)
            {
                numLinesInFile++; //Gets number of lines in file
            }

            openRecentStream.BaseStream.Position = 0;
            openRecentStream.DiscardBufferedData();

            if (numLinesInFile <= 0)
            {
                openRecentToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("(none)"));
            }
            else
            {
                openRecentToolStripMenuItem.DropDownItems.Clear();
            }
            

            //Moves the reading point of the stream such that the last ten entries are the only ones being added
            //10 was a good number in Chris' opinion to end at, else the list might get too long
            if(numLinesInFile > 10)
            {
                for(int counter = 0; counter < numLinesInFile - 10; counter++)
                {
                    openRecentStream.ReadLine();
                }
            }

            while((lineOfFile = openRecentStream.ReadLine()) != null)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem(lineOfFile);
                newItem.Click += new EventHandler(openRecentClickHandler);
                openRecentToolStripMenuItem.DropDownItems.Add(newItem);
            }
            openRecentStream.Close();
        }

        private void openRecentClickHandler(Object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            OpenFile(clickedItem.Text);

            //Update the text box in editor form to the file we just opened
            this.textEditorBox.Text = textProperties.fileText;
            this.Text = textProperties.fileTitle; //Changes title of form to file name
            this.DesktopLocation = textProperties.formLoc;
            fileIsSaved = true; //File that was just opened is already up to date

            updateEditorBox();
        }
    }
}
