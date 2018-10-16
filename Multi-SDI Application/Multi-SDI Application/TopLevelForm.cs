using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibraryAssign3;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;


namespace Multi_SDI_Application
{
    public partial class TopLevelForm : BaseMainForm
    {
        //Variables
        private string filename { get; set; }
        private string fileFilter;
        private SerializableProperties serializableProperties;
      //  private MenuStrip menuStrip;

        //Enumerations
        private enum shape { Ellipse, Rectangle, Custom};
        private enum pen { Solid, Dashed, Compound};
        private enum brush { LinearGradient, Hatched, Solid}

        public TopLevelForm()
        {
            InitializeComponent();
            serializableProperties = new SerializableProperties();
            fileFilter = "Files|*.ok";

            /*menuStrip = new MenuStrip();
            menuStrip.SuspendLayout();
            menuStrip.ImageScalingSize = new Size(20, 20);
            ToolStripMenuItem item = new ToolStripMenuItem();
            menuStrip.Items.Add(item);
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip2";
            menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            menuStrip.Size = new System.Drawing.Size(1067, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip2";
            this.Controls.Add(menuStrip);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();*/
            Shape shape = new Shape();
        }


        //Creates new top level window
        public static TopLevelForm CreateWindow(string filename)
        {
            if (!String.IsNullOrEmpty(filename))
            {
                foreach(TopLevelForm form in Application.OpenForms)
                {
                    if (String.Compare(form.filename, filename, true) == 0) //Checks if file is already open
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            TopLevelForm newForm = new TopLevelForm();
            newForm.OpenFile(filename);
            newForm.Show();
            newForm.Text = "Untitled";
            newForm.Activate();
            return newForm;
        }

        private void OpenFile(String filename)
        {
            
        }

        //Override of Oath Tool Strip Menu Item Handler
        public override void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog oathDlg = new OathDialog();
            oathDlg.Owner = this;

            try
            {
                oathDlg.Show();
            } catch
            {
                throw new NotSupportedException("Oath Dialog not supported");
            }
            
        }

        //Override of About Tool Strip Menu Item Handler
        public override void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog abtDlg = new AboutDialog();
            abtDlg.Owner = this;

            try
            {
                abtDlg.Show();
            }
            catch
            {
                throw new NotSupportedException("About Dialog not supported");
            }
        }

        //Override of New Window Tool Strip Menu Item Handler
        public override void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWindow("");
            updateWindowMenu();
        }

        public override void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = fileFilter;
            saveFileDialog.Title = "Save file";

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            if (Serializer.Serialize(saveFileDialog.FileName, serializableProperties))
                Console.WriteLine(saveFileDialog.FileName + " saved succesfully");
            else
                Console.WriteLine("Failed to save file");
        }

        
        public override void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            SerializableProperties temp;
            if ((temp = Serializer.Deserialize(openFileDialog.FileName)) != null)
                serializableProperties = temp;
            else
                Console.WriteLine("Failed");
        }

        //Used to update the Window Menu Items
        private void updateWindowMenu()
        {
            
        }
    }
}
