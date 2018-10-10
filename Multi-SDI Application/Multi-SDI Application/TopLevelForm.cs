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


namespace Multi_SDI_Application
{
    public partial class TopLevelForm : BaseForm
    {
        public TopLevelForm()
        {
            InitializeComponent();
        }

        String filename { get; set; }

        public static TopLevelForm CreateWindow(string filename)
        {
            if (!String.IsNullOrEmpty(filename))
            {
                foreach(TopLevelForm form in Application.OpenForms)
                {
                    if (String.Compare(form.filename, filename, true) == 0)
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            TopLevelForm newForm = new TopLevelForm();
            newForm.OpenFile(filename);
            newForm.Show();
            newForm.Activate();
            return newForm;
        }

        private void OpenFile(String filename)
        {
            
        }
    }
}
