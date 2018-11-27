using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace FinalAssignmentTeam2
{
    class MultiSDI : WindowsFormsApplicationBase
    {
        //All windows and tabs mustg have access to the same history/favorites
        public SingleLinkedList history;
        public SingleLinkedList favorites;
        public SettingsProperties settingsProperties;

        private static MultiSDI appli;
        internal static MultiSDI Appli
        {
            get
            {
                if (appli == null)
                {
                    appli = new MultiSDI();
                }
                return appli;
            }
        }

        public MultiSDI()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
            history = new SingleLinkedList();
            favorites = new SingleLinkedList();
            settingsProperties = new SettingsProperties();
        }

        //Create first top level form
        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        // Create subsequent top-level form
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            this.CreateTopLevelWindow(e.CommandLine);
        }

        private Form CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            String fileName = null;
            if (args.Count > 0)
                fileName = args[0];

            return FinalAssignmentTeam2.Browser.CreateWindow();
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            if (form == this.MainForm &&
                this.OpenForms.Count > 0)
            {
                this.MainForm = (Form)this.OpenForms[0];
            }
            form.FormClosed -= form_FormClosed;
        }

        public void AddTopLevelForm(Form form)
        {
            form.FormClosed += form_FormClosed;
        }

    }
}
