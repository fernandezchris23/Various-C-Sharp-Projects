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
        //All windows and tabs must have access to the same history/favorites
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
            GetSavedState();
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

        public bool SaveState()
        {
            if (SaveSettings() && SaveHistory() && SaveFavorites())
                return true;

            return false;
        }

        public bool SaveSettings()
        {
            if (Serializer.Serialize("settings", settingsProperties))
                return true;

            return false;
        }

        public bool SaveHistory()
        {
            if (Serializer.Serialize("history", history))
                return true;

            return false;
        }

        public bool SaveFavorites()
        {
            if (Serializer.Serialize("favorite", favorites))
                return true;

            return false;
        }

        public void GetSavedState()
        {
            if ((settingsProperties = OpenSettings()) == null)
                settingsProperties = new SettingsProperties();

            if ((history = OpenHistory()) == null)
                history = new SingleLinkedList();


            if ((favorites = OpenFavotires()) == null)
                favorites = new SingleLinkedList();
        }

        public SettingsProperties OpenSettings()
        {
            return (SettingsProperties)Serializer.Deserialize("settings");
        }



        public SingleLinkedList OpenHistory()
        {
            return (SingleLinkedList)Serializer.Deserialize("history");
        }

        public SingleLinkedList OpenFavotires()
        {
            return (SingleLinkedList)Serializer.Deserialize("favorite");
        }

    }
}
