using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;

namespace Multi_SDI_Application
{
    class MultiSDIApp : WindowsFormsApplicationBase
    {
        private static MultiSDIApp application;
        internal static MultiSDIApp Application
        {
            get
            {
                if (application == null)
                    application = new MultiSDIApp();
                return application;
            }
            
        }

        public MultiSDIApp()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        private Form CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            String fileName = null;
            if (args.Count > 0)
                fileName = args[0];

            return TopLevelForm.CreateWindow(fileName);
        }


    }
}
