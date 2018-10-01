using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void UpdateValues(PrefsDialog prefsDialog)
        {
            this.textProperties.textColor = prefsDialog.TextProperties.textColor;
            this.textProperties.textFont = prefsDialog.TextProperties.textFont;
            this.textEditorBox.BackColor = prefsDialog.TextProperties.bgColor;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textProperties.fileText = this.textEditorBox.Text;
        }
    }
}
