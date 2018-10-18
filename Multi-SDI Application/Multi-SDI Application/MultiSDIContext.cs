﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;

namespace Multi_SDI_Application
{
    class MultiSDIApp : WindowsFormsApplicationBase//, IWindowMenu
    {
        private static MultiSDIApp application;
        internal static MultiSDIApp Application
        {
            get
            {
                if (application == null)
                    application = new MultiSDIApp(); //If no spplication exists, create one
                return application;
            }
            
        }

        public MultiSDIApp()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
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

            return TopLevelForm.CreateWindow(fileName);
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

        void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            menu.DropDownItems.Clear();
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
                item.Tag = form;
                item.Click += item_Click;
                item.Checked = form == Form.ActiveForm;
                menu.DropDownItems.Add(item);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }

        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        }

    }
}
