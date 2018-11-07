using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assign2
{
    public partial class UserSettings : Form
    {
        enum ValidationError { Valid, Empty, Space, Length };
        private string nameUser; //Used to store text entered by user
        private const int MAX_CHAR = 15; //Maximum characters alotted

        public UserSettings()
        {
            InitializeComponent();
            this.notifyIcon1.Icon = SystemIcons.Application;
            this.notifyIcon1.BalloonTipText = "System tray";
            this.notifyIcon1.ShowBalloonTip(1000);
        }

        // Properties with setters/getters instead of typing Properities.Settings every time
        public Size UserSize { get { return Properties.Settings.Default.UserSize; } set { Properties.Settings.Default.UserSize = (value); } }
        public Point UserLocation { get { return Properties.Settings.Default.UserLocation; } set { Properties.Settings.Default.UserLocation = (value); } }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(UserLocation.X, UserLocation.Y); //Loads in and sets DesktopLocation from settings
            this.ClientSize = new Size(UserSize.Width, UserSize.Height); //Loads in ClientSize from settings
            this.SetClientSizeCore(UserSize.Width, UserSize.Height); //Sets loaded in ClientSize
        }

        //Handler for TextBox for user input. Saves text entered into variable when text is changed
        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            TextBox name = (TextBox)nameBox; //Connects to TextBox on form

            string textFromBox = name.Text; //Grabs text to store for later
            nameUser = textFromBox;
        }
        
        //Reset Settings Button Handler
        private void resetSettBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        //Save Size Button Handler
        private void saveSizeBttn_Click(object sender, EventArgs e)
        {
            UserSize = new Size(this.ClientSize.Width, this.ClientSize.Height); //Saves size of client to settings
            Properties.Settings.Default.Save(); //Save Properties
        }

        //Save Location Button Handler
        private void saveLocBttn_Click(object sender, EventArgs e)
        {
           UserLocation = this.DesktopLocation; //Copies Location settings to Properties for saving
           Properties.Settings.Default.Save(); //Save Properties
        }

        //Add Name Button Handler
        private void addNameBttn_Click_1(object sender, EventArgs e)
        {
            Enum validName = ValidateString(nameUser);
            switch (validName)
            {
                case ValidationError.Empty:
                    errorProvider1.SetError(nameBox, "Text Field is empty! Please enter something!");
                    break;

                case ValidationError.Space:
                    errorProvider1.SetError(nameBox, "Names must contain at least 1 non-space character!");
                    break;

                case ValidationError.Length:
                    errorProvider1.SetError(nameBox, "No more than 15 characters may be used!");
                    break;

                default:
                    errorProvider1.Clear(); //Clears any previous errorprovider if now valid
                    AddListBox(nameUser); //Adds data to ListBox
                    break;
            }

        }

        //Handles Validation of text entered
        private ValidationError ValidateString(string validateString)
        {
            if (String.IsNullOrEmpty(validateString))
                return ValidationError.Empty;
            else if (validateString.Length > MAX_CHAR)
                return ValidationError.Length;
            else if (validateString.Trim().Length == 0)
                return ValidationError.Space;

            int count = 0;
            foreach (char c in validateString)
                if (char.IsLetter(c))
                    ++count;

            return (validateString.Length == count) ? ValidationError.Valid : ValidationError.Space;
        }

        //Adds valid text entered to ListBox
        private void AddListBox(string str)
        {
            this.listView1.Items.Add(new ListViewItem(str));
        }

        //Catches closing of form while list creation in progress
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.listView1.Items.Count > 0 && (MessageBox.Show("Abort?", "List in progress", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                e.Cancel = true;
                ActivateForm();
            }
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActivateForm();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ActivateForm()
        {
            this.Show();
            this.Focus();
            this.Activate();
        }
    }
}
