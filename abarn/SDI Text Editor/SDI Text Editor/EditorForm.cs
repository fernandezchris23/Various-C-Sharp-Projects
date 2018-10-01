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

        TextProperties textProperties;

        public EditorForm()
        {
            textProperties = new TextProperties();
            InitializeComponent();
            UpdateEditorBox();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void preferencesButton_Click(object sender, EventArgs e)
        {
            PrefsDialog prefsDialog = new PrefsDialog(this, textProperties);
            prefsDialog.Show();
        }

        public void UpdateValues(TextProperties properties)
        {
            this.textProperties.textColor = properties.textColor;
            this.textProperties.textFont = properties.textFont;
            this.textProperties.bgColor = properties.bgColor;

            UpdateEditorBox();
        }
        
        //Update the actual text editor
        public void UpdateEditorBox()
        {
            this.textEditorBox.ForeColor = textProperties.textColor;
            this.textEditorBox.Font = textProperties.textFont;
            this.textEditorBox.BackColor = textProperties.bgColor;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textProperties.fileText = this.textEditorBox.Text;

            if (this.saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filename = this.saveFileDialog.FileName;
            SaveToFile(textProperties, filename);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            string filename = this.openFileDialog.FileName;
            OpenFile(filename);
            this.textEditorBox.Text = textProperties.fileText;
            UpdateEditorBox();
        }

        public void SaveToFile(TextProperties properties, String filename)
        {
            Stream stream = File.OpenWrite(filename);

            BinaryFormatter binF = new BinaryFormatter();

            binF.Serialize(stream, properties);
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        public void OpenFile(String filename)
        {
            BinaryFormatter binF = new BinaryFormatter();

            FileStream stream = File.Open(filename, FileMode.Open);

            object obj = binF.Deserialize(stream);
            TextProperties properties = (TextProperties)obj;

            stream.Flush();
            stream.Close();
            stream.Dispose();
        }
    }
}
